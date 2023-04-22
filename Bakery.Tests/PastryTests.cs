using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
     [TestMethod]
    public void Pastry_InstantiatePastry_ReturnPastry()
    {
       Pastry testPastry = new Pastry(2.00m, 3);
       
       testPastry.Price = 2.00m;
       testPastry.Quantity = 3;

       Assert.AreEqual(2.00m, testPastry.GetPrice());
       Assert.AreEqual(3, testPastry.GetQuantity());
    }

     [TestMethod]
    public void SetPrice_SetPriceValue_ReturnCorrectValue()
    {
      Pastry testPastry = new Pastry(2.00m, 5);
      decimal expectedPrice = 2.00m;
      
      testPastry.Price = expectedPrice;
      decimal actualPrice = testPastry.GetPrice();

      Assert.AreEqual(actualPrice, expectedPrice);
    }

      [TestMethod]
    public void SetQuantity_SetQuantityValue_ReturnCorrectValue()
    {
      Pastry testPastry = new Pastry(2.00m, 10);
      int expectedQuantity = 10;

      testPastry.Quantity = expectedQuantity;
      int actualQuantity = testPastry.GetQuantity();

      Assert.AreEqual(actualQuantity, expectedQuantity);
    }
      [TestMethod]
    public void GetPrice_GetValueOfPrice_ReturnPrice()
    {
      Pastry testPastry = new Pastry(2.00m, 4);
      testPastry.Price = 2.00m;

      decimal actualPrice = testPastry.GetPrice();

      Assert.AreEqual(2.00m, actualPrice);
    }

     [TestMethod]
    public void GetQuantity_GetValueOfQuantity_ReturnQuantity()
    {
      Pastry testPastry = new Pastry (2.00m, 4);
      testPastry.Quantity = 4;

      int actualQuantity = testPastry.GetQuantity();

      Assert.AreEqual(4, actualQuantity);
    }

     [TestMethod]
    public void CalculateCost_GetTotalPastries_ReturnCost()
    {
      Pastry testPastry = new Pastry (2.00m, 4);

      decimal cost = testPastry.GetPrice() * testPastry.GetQuantity(); 

      Assert.AreEqual(8.00m, cost);
    }

     [TestMethod]
    public void DiscountPrice_GiveDiscount_ReturnTotalCost()
    {
      Pastry testPastry = new Pastry(2.00m, 6);

      decimal cost = testPastry.GetPrice() * testPastry.GetQuantity();
      int discountPastries = testPastry.GetQuantity() / 4;
      decimal freePastry = discountPastries * 2.00m;
      decimal totalCost = cost -= freePastry;

      Assert.AreEqual(10.00m, totalCost); 
    }
  }
}
