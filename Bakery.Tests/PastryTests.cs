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
       Pastry testPastry = new Pastry();
       
       testPastry.Price = 2.00m;
       testPastry.Quantity = 3;

       Assert.AreEqual(2.00m, testPastry.Price);
       Assert.AreEqual(3, testPastry.Quantity);
    }

  }
}