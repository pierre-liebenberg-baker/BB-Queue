using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_Queue
{
  public class Models
  {

    public class MenuItem
    {
      public string Name { get; set; }
      public double Price { get; set; }
    }

    public class OrderItem
    {
      public int OrderNumber { get; set; }
      public string OrderType { get; set; }
      public int ItemCount { get; set; }
      public double TotalPrice { get; set; }
      public string OrderStatus { get; set; }
      public DateTime OrderTime { get; set; }
    }
  }
}
