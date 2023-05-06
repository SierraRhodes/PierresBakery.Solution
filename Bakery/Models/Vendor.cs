using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor 
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; } = new List<Order>();
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
    }

  }
}