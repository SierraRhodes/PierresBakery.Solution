using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void Order_InstantiateOrder_ReturnOrder()
    {
    
      string item = "Croissant";
      int quantity = 3;
      DateTime date = new DateTime(2023, 5, 2);

      Order testOrder = new Order(item, quantity, date);


      Assert.AreEqual("Croissant", testOrder.Item);
      Assert.AreEqual(date.ToShortDateString(), testOrder.Date.ToShortDateString());
      Assert.AreEqual(3, testOrder.Quantity);
      

    }
  }
}