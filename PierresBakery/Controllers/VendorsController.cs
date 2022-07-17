using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
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
      Vendor myVendor = new Vendor(name, description);
      return RedirectToAction("Index", myVendor);
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("order", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, string orderPrice, DateTime orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("order", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}