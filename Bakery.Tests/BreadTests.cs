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
       Assert.AreEqual(2, testBread.Quantity);
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
      int actualQuantity = testBread.Quantity;

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

  }
}