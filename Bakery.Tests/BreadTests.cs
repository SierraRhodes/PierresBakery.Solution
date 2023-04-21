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
       Bread testBread = new Bread();
       testBread.Price = 5.00m;
       testBread.Quantity = 2;

       Assert.AreEqual(5.00m, testBread.Price);
       Assert.AreEqual(2, testBread.Quantity);
    }
  }
}