namespace Bakery.Models
{
  public class Pastry
  {
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Pastry (decimal Price, int Quantity)
    {
      this.Price = Price;
      this.Quantity = Quantity;
    }
    public decimal GetPrice()
    {
      return Price;
    }

    public int GetQuantity()
    {
      return Quantity;
    }


  }

}