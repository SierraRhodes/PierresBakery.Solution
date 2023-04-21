namespace Bakery.Models
{
  public class Bread
  {
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Bread (decimal Price, int Quantity)
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
    public decimal CalculateCost()
    {
      decimal pricePerLoaf = GetPrice();
      int quantity = GetQuantity();
      int discountLoaves = quantity / 2;
      decimal freeLoaves = discountLoaves *  5.00m;
      decimal cost = pricePerLoaf * quantity;
      decimal totalCost = cost -= freeLoaves;
      return totalCost;  
    }
  }
}