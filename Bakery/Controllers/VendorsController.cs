using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
 public class VendorsController : Controller
 {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendors = Vendor.GetAll();
      return View(vendors);
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
    Vendor vendor = Vendor.Find(id);
    return View(vendor);


   }
 }
}