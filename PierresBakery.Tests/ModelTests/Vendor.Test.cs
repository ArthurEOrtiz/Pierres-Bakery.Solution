using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class VendorTests
  {
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
  }
}