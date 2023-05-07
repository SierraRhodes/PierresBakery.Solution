using System.Collections.Generic;
using System;

namespace Bakery.Models 
{
  public class Order
  {
    public string Item { get; set; }
    public int Quantity { get; set; }
    public DateTime Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string item, int quantity, DateTime date)
    {
      Item = item;
      Quantity = quantity;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;

    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
  
}