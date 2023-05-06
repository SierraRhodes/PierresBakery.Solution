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
  }
} 