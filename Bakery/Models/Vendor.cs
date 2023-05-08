using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor 
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _instances = new List<Vendor>();
     public int Id { get; }
  
    public int OrderCount
    {
      get
      {
        return Orders.Count;
      }
    }
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }
    public static List<Vendor>GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
       public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }
     public void AddItem(Order order)
  {
    Orders.Add(order);
  }


  }
}