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

       Assert.AreEqual(2.00m, testPastry.Price);
       Assert.AreEqual(3, testPastry.Quantity);
    }

     [TestMethod]
    public void SetPrice_SetPriceValue_ReturnCorrectValue()
    {
      Pastry testPastry = new Pastry(2.00m, 5);
      decimal expectedPrice = 2.00m;
      
      testPastry.Price = expectedPrice;
      decimal actualPrice = testPastry.Price;

      Assert.AreEqual(actualPrice, expectedPrice);
    }

      [TestMethod]
    public void SetQuantity_SetQuantityValue_ReturnCorrectValue()
    {
      Pastry testPastry = new Pastry(2.00m, 10);
      int expectedQuantity = 10;

      testPastry.Quantity = expectedQuantity;
      int actualQuantity = testPastry.Quantity;

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
  }
}
