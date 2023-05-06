using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void Vendor_InstantiateVendor_ReturnVendor()
    {
      Vendor testVendor = new Vendor("Rainbow Teahouse", "A teahouse");
      DateTime orderDate = new DateTime(2023, 5, 5);
      Order testOrder = new Order("Croissant", 3, orderDate);

      Assert.IsNotNull(testVendor.Orders);
    }
    [TestMethod]
    public void Vendor_CountOrders_ReturnCount()
    {
      Vendor testVendor = new Vendor("Rainbow Teahouse", "A teahouse");
      testVendor.Orders.Add(new Order("Croissant", 3, new DateTime(2023, 5, 2)));
      testVendor.Orders.Add(new Order("Baguette", 2, new DateTime(2023, 5, 2)));
      testVendor.Orders.Add(new Order("Pain au chocolat", 5, new DateTime(2023, 5, 2)));

      int orderCount = testVendor.Orders.Count;

      Assert.AreEqual(3, orderCount);

    }
  }
} 