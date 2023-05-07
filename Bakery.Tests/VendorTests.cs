using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
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
    [TestMethod]
    public void GetAll_ReturnAllVendors_VendorList()
    {
      Vendor vendor1 = new Vendor("Bakery A", "Description A");
      Vendor vendor2 = new Vendor("Bakery B", "Description B");
      List<Vendor> expectedVendors = new List<Vendor> {vendor1, vendor2};

      List<Vendor> actualVendors = Vendor.GetAll();

      CollectionAssert.AreEqual(expectedVendors, actualVendors);
      
    }
    //  [TestMethod]
    //  public void ClearAll_ClearVendorList_VendorsList()
    //  {
    //   Vendor testVendor = new Vendor("Rainbow Teahouse", "A teahouse");
    //   Vendor.ClearAll();

    //   List<Vendor> expectedList = new List<Vendor>();
    //   List<Vendor> resultList = Vendor.GetAll();

    //   CollectionAssert.AreEqual(expectedList, resultList);



    //  }
  }
} 