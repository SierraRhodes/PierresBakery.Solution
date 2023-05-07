using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
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
    [TestMethod]
    public void GetId_InstantiateOrderId_ReturnOrderId()
    {
      DateTime orderDate = new DateTime(2020, 5, 2);
      Order testOrder = new Order("Baguette", 3, orderDate);

      int result = testOrder.Id;
      
      Assert.AreEqual(1, result);
    }
  }
}