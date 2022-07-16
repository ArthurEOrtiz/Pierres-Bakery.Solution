using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery;
using System;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test","test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      string name = "Rise and Shine";
      Vendor newVendor = new Vendor(name, "test");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      string name = "Bread'n'Stuff";
      Vendor newVendor = new Vendor(name, "test");

      string updatedName = "Stuf'n'Bread";
      newVendor.Name = updatedName;
      string result = newVendor.Name;

      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetDescription_ReturnDes_String()
    {
      string description = "Coffee and brunch place";
      Vendor newVendor = new Vendor("test", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Little shop in the sticks";
      Vendor newVendor = new Vendor("test", description);

      string updatedDescription = "Little shop downtown";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newVendorList = new List<Vendor> { };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newVendorList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendorList_VendorList()
    {
      string Vendor01 = "Jewel";
      string Vendor02 = "Albertsons";
      Vendor newVendor1 = new Vendor(Vendor01, "test");
      Vendor newVendor2 = new Vendor(Vendor02, "test");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2};

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_VendorInstantiateWithAnIDAndGetterReturn_Int()
    {
      string vendor = "Whole Foods";
      string description = "'health' food store.";
      Vendor newVendor = new Vendor(vendor, description);

      int result = newVendor.Id;

      Assert.AreEqual(1,result);
    }
  }
}