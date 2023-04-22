using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_InstantiateBread_ReturnBread()
    {
       Bread testBread = new Bread(5.00m, 2);

       Assert.AreEqual(5.00m, testBread.GetPrice());
       Assert.AreEqual(2, testBread.GetQuantity());
    }

    [TestMethod]
    public void SetPrice_SetPriceValue_ReturnCorrectValue()
    {
      Bread testBread = new Bread(5.00m, 2);
      decimal expectedPrice = 5.00m;
      
      testBread.Price = expectedPrice;
      decimal actualPrice = testBread.GetPrice();

      Assert.AreEqual(actualPrice, expectedPrice);
    }

    [TestMethod]
    public void SetQuantity_SetQuantityValue_ReturnCorrectValue()
    {
      Bread testBread = new Bread(5.00m, 2);
      int expectedQuantity = 2;

      testBread.Quantity = expectedQuantity;
      int actualQuantity = testBread.GetQuantity();

      Assert.AreEqual(actualQuantity, expectedQuantity);
    }

    [TestMethod]
    public void GetPrice_GetValueOfPrice_ReturnPrice()
    {
      Bread testBread = new Bread(5.00m, 2);
      testBread.Price = 5.00m;

      decimal actualPrice = testBread.GetPrice();

      Assert.AreEqual(5.00m, actualPrice);
    }

    [TestMethod]
    public void GetQuantity_GetValueOfQuantity_ReturnQuantity()
    {
      Bread testBread = new Bread(5.00m, 2);
      testBread.Quantity = 2;

      int actualQuantity = testBread.GetQuantity();

      Assert.AreEqual(2, actualQuantity);
    }

    [TestMethod]
    public void CalculateCost_GetTotalBread_ReturnCost()
    {
      Bread testBread = new Bread(5.00m, 2);

      decimal cost = testBread.GetPrice() * testBread.GetQuantity(); 

      Assert.AreEqual(10.00m, cost);
    }

    [TestMethod]
    public void DiscountPrice_GiveDiscount_ReturnTotalCost()
    {
      Bread testBread = new Bread(5.00m, 10);

      decimal cost = testBread.GetPrice() * testBread.GetQuantity();
      int discountLoaves = testBread.GetQuantity() / 3;
      decimal freeLoaf = discountLoaves * 5.00m;
      decimal totalCost = cost -= freeLoaf;

      Assert.AreEqual(35.00m, totalCost); 
    }


    [TestMethod]
    public void TotalAmountDue_CalculateBreadAndPastry_ReturnTotalDdue()
    {
      Bread testBread = new Bread(5.00m, 2);
      Pastry testPastry = new Pastry(2.00m, 5);

      decimal totalDue = testBread.CalculateCost() + testPastry.CalculateCost();

      Assert.AreEqual(18.00m, totalDue);
    }
  }
}