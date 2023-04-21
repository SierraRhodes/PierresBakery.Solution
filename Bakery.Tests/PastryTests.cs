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
  }
}
