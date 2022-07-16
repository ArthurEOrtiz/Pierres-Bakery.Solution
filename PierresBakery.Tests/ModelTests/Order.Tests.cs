using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class OrderTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }

    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description");

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string title = "Initial Purchase";
      Order newOrder = new Order(title, "description");

      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Initial Purchase";
      Order newOrder = new Order(title, "description");

      string updatedTitle = "Seconday Purchase";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "Initial bulk purchase.";
      Order newOrder = new Order("title", description);

      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }
    
  }
}