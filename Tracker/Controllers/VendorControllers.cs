using System.Collections.Generic;
using System;
using Microsoft.AspnETcORE.Mvc;
using Tracker.Models;

namespace Tracker.Controllers{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendors/new")]
        public actionResult New()
        {
            return View();
        }

        [HttpGet("/vendors/{id}")]
        public Actionresult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(id);
            List<Order> vendorOrders = selectedVendor.Orders;
            model.Add("vendor", selectedVendor);
            model.Add("orders", vendororders);
            return View(model);        
        }

        
    }
}