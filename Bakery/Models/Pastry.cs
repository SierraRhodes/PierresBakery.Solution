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

     public decimal CalculateCost()
    {
      decimal pricePerPastry = GetPrice();
      int quantity = GetQuantity();
      int discountPastries = quantity / 4;
      decimal freePastries = discountPastries * 2.00m;
      decimal cost = pricePerPastry * quantity;
      decimal totalCost = cost -= freePastries;
      return totalCost;
    }


  }

}