using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static BB_Queue.Models;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;

namespace BB_Queue
{
  public class OrderManager
  {
   
    public int toysAvailable = 50;
    private int _currentMrDOrderNumber = 10000;
    private int _currentPosOrderNumber = 1;
    private Random rndItem = new Random();

    public OrderManager()
    {
      Orders = new BindingList<Order>();
      CollectedOrders = new BindingList<Order>();
    }

    public BindingList<Order> Orders { get; set; }
    public BindingList<Order> CollectedOrders { get; set; }

    DataTable DataTableOrders { get; set; }

    List<MenuItem> menuItems = new List<MenuItem>() {
      new MenuItem() { Name ="Burger", Price = 65.95},
      new MenuItem() { Name ="Chips", Price = 20.95},
      new MenuItem() { Name ="Soda", Price = 10.00},
      new MenuItem() { Name ="Smiley Meal", Price = 35.50}
    };

    public void CreateOrder(OrderType orderType, DateTime orderTime)
    {
      int orderNumber;
      if(orderType == OrderType.MrD)
      {
        orderNumber = _currentMrDOrderNumber;
        _currentMrDOrderNumber++;
      }
      else
      {
        orderNumber = _currentPosOrderNumber;
        _currentPosOrderNumber++;
      }

      int orderItemCount = rndItem.Next(1, 5);

      List<MenuItem> orderItems = new List<MenuItem>();

      for (int i = 1; i <= orderItemCount; i++)
      {
        int menuItemIndex = rndItem.Next(0, 4);
        orderItems.Add(menuItems[menuItemIndex]);
      }

      Order order = new Order();

      order.OrderNumber = orderNumber;
      order.OrderType = orderType.ToString();
      
      order.OrderTime = orderTime;
      int smileyMeals = orderItems.Where(w => w.Name == "Smiley Meal").Count();
      double totalPrice = orderItems.Sum(w => w.Price);

      if (smileyMeals <= toysAvailable && smileyMeals > 0)
      {
        toysAvailable -= smileyMeals;

        order.OrderStatus = OrderStatus.Placed.ToString();
        order.ToyIncluded = ToyIncluded.Yes.ToString();
        order.TotalPrice = totalPrice;
        order.ItemCount = orderItemCount;
        Orders.Add(order);
      }
      else if(smileyMeals > toysAvailable)
      {
        order.OrderStatus = OrderStatus.Rejected.ToString();
        order.ToyIncluded = ToyIncluded.No.ToString();
        order.TotalPrice = totalPrice;
        order.ItemCount = orderItemCount;
        CollectedOrders.Add(order);
      }
      else
      {
        order.OrderStatus = OrderStatus.Placed.ToString();
        order.ToyIncluded = ToyIncluded.No.ToString();
        order.TotalPrice = totalPrice;
        order.ItemCount = orderItemCount;
        Orders.Add(order);
      }

    }

    public void MarkAsCollected(DateTime simulatedTime)
    {
      List<Order> ordersToRemove = Orders.Where(w => w.OrderTime.AddMinutes(10) < simulatedTime).ToList();
      foreach(Order order in ordersToRemove)
      {
        Orders.Remove(order);
        order.OrderStatus = OrderStatus.Collected.ToString();
        CollectedOrders.Add(order);
      }
    }

  }
}
