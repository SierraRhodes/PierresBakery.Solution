using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/vendors/{id}/orders/new")]
       public ActionResult New()
       {
         return View();
       }

        // [HttpPost("/vendors/{id}/orders")]
        // public ActionResult Create(int id, string item, int quantity, DateTime date)
        // {
        //     Vendor vendor = Vendor.Find(id);
        //     Order newOrder = new Order(item, quantity, date);
        //     vendor.Orders.Add(newOrder);
        //     return RedirectToAction();
        // }
    }
}