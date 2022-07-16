using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class OrderTests // : IDisposable
  {
  //   // public void Dispose()
  //   // {
  //   //   Order.ClearAll();
  //   // }

    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      DateTime date = new DateTime(2020, 7, 16, 14, 32, 0);
      Order newOrder = new Order("title", "description", 12.34, date);

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string title = "Initial Purchase";
      DateTime date = new DateTime(2020, 7, 16, 14, 32, 0);
      Order newOrder = new Order(title, "description", 12.34, date);

      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Initial Purchase";
      DateTime date = new DateTime(2020, 7, 16, 14, 32, 0);
      Order newOrder = new Order(title, "description", 12.34, date);

      string updatedTitle = "Seconday Purchase";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "Initial bulk purchase.";
      DateTime date = new DateTime(2020, 7, 16, 14, 32, 0);
      Order newOrder = new Order("title", description, 12.34, date);

      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Initial bulk purchas.";
      DateTime date = new DateTime(2020, 7, 16, 14, 32, 0);
      Order newOrder = new Order("title", description, 12.34, date);

      string updatedDescription = "Expedited purchse, deliver to bob.";
      newOrder.Description = updatedDescription;

      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPrice_Double()
    {
      double price = 12.34;
      DateTime date = new DateTime(2020, 7, 16, 14, 32, 0);
      Order newOrder = new Order("title", "description", price, date);

      double result = newOrder.Price;

      Assert.AreEqual(price, result);

    }

    [TestMethod]
    public void SetPrice_SetPrice_Double()
    {
      double price = 12.34;
      DateTime date = new DateTime(2020, 7, 16, 14, 32, 0);
      Order newOrder = new Order("titel", "description", price, date);

      double updatedPrice = 56.78;
      newOrder.Price = updatedPrice;

      double result = newOrder.Price;

      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetDate_ReturnDate_DateTime()
    {
      DateTime date = new DateTime(2020, 7, 16, 14, 32, 0);
      Order newOrder = new Order("Title", "description", 12.34, date);

      DateTime result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_SetDate_DateTime()
    {
      DateTime date = new DateTime(2020, 7, 16, 14, 32, 0);
      Order newOrder = new Order("Title", "description", 12.34, date);

      DateTime newDate = new DateTime(2020, 7, 16, 14, 46, 0);
      newOrder.Date = newDate;

      DateTime result = newOrder.Date;

      Assert.AreEqual(newDate, result);

    }


  }
}