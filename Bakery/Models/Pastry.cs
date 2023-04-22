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

    public decimal TotalAmountDue(int breadQuantity, int pastryQuantity)
    {
      Bread breadOrder = new Bread(0.00m, 0);
      Pastry pastryOrder = new Pastry(0.00m, 0);
      decimal totalDue = breadOrder.CalculateCost() + pastryOrder.CalculateCost();
      return totalDue;
    }


  }

}