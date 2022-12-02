using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BB_Queue.Models;

namespace BB_Queue
{
  public class Order
  {
    public int OrderNumber { get; set; }
    public string OrderType { get; set; }
    //public string ItemDescription;
    //public double ItemPrice;
    public int ItemCount { get; set; }
    public double TotalPrice { get; set; }
    public string ToyIncluded { get; set; }
    public string OrderStatus { get; set; }
    public DateTime OrderTime { get; set; }

  }
}
