using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Controllers
{
 public class VendorsController : Controller
 {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
  
   [HttpGet("/vendors/new")]
   public ActionResult New()
   {
    return View();
   }
   [HttpPost("/vendors")]
   public ActionResult Create(string name, string description)
   {
     Vendor newVendor = new Vendor(name, description);
     return RedirectToAction("Index");
   }
   [HttpPost("/vendors/clearall")]
   public ActionResult ClearAll()
   {
    Vendor.ClearAll();
    return RedirectToAction("Index");
   }
   [HttpGet("/vendors/{id}")]
   public ActionResult Show(int id)
   {
    Dictionary<string, object> model = new Dictionary<string, object>();
    Vendor selectedVendor = Vendor.Find(id);
    List<Order> foundOrders = selectedVendor.Orders;
    model.Add("vendor", selectedVendor);
    model.Add("orders", foundOrders);
    return View(model);

   }
     [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string item, int quantity, DateTime date)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(item, quantity, date);
      foundVendor.AddItem(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendors", foundVendor);
      return View("Show", model);
    }
   
 }
}