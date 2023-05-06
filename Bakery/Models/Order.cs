using System.Collections.Generic;
using System;

namespace Bakery.Models 
{
  public class Order
  {
    public string Item { get; set; }
    public int Quantity { get; set; }
    public DateTime Date { get; set; }
    public Order(string item, int quantity, DateTime date)
    {
      Item = item;
      Quantity = quantity;
      Date = date;
    }
  }
  
  
}