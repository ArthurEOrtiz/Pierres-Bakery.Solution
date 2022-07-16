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
      Order newOrder = new Order("title", "description", 12.34);

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string title = "Initial Purchase";
      Order newOrder = new Order(title, "description", 12.34);

      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Initial Purchase";
      Order newOrder = new Order(title, "description", 12.34);

      string updatedTitle = "Seconday Purchase";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "Initial bulk purchase.";
      Order newOrder = new Order("title", description, 12.34);

      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Initial bulk purchas.";
      Order newOrder = new Order("title", description, 12.34);

      string updatedDescription = "Expedited purchse, deliver to bob.";
      newOrder.Description = updatedDescription;

      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPrice_Double()
    {
      double price = 12.34;
      Order newOrder = new Order("title", "description", price);

      double result = newOrder.Price;

      Assert.AreEqual(price, result);

    }

    [TestMethod]
    public void SetPrice_SetPrice_Double()
    {
      double price = 12.34;
      Order newOrder = new Order("titel", "description", price);

      double updatedPrice = 56.78;
      newOrder.Price = updatedPrice;

      double result = newOrder.Price;

      Assert.AreEqual(updatedPrice, result);
    }
  }
}