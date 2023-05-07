using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

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
      [TestMethod]
    public void GetAll_ReturnAllOrders_OrderList()
    {
      DateTime orderDate = new DateTime(2020, 5, 2);
      Order order1 = new Order("Baguette", 3, orderDate);
      DateTime orderDate2 = new DateTime(2021, 4, 22);
      Order order2 = new Order("Pastry", 3, orderDate2);
      List<Order> expectedOrders = new List<Order> {order1, order2};

      List<Order> actualOrders = Order.GetAll();

      CollectionAssert.AreEqual(expectedOrders, actualOrders);  
    }
      [TestMethod]
      public void Find_ReturnCorrectOrder_Order()
      {
        Order testOrder1 = new Order("Croissant", 2, new DateTime(2023, 5, 2));
        Order testOrder2 = new Order("Baguette", 5, new DateTime(2022, 4, 22));

        Order result = Order.Find(2);

        Assert.AreEqual(testOrder2, result);
      }
  }
}