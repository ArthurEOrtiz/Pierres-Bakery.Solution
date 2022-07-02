using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class MenuItemsTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread firstBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), firstBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_ReturnsValueOfQuantity_One()
    {
      Bread secondBread = new Bread(1);
      Assert.AreEqual(secondBread.GetQuantity(),1);
    }

    [TestMethod]
    public void BreadConstructor_ReturnsValueofPrice_Thirtyfive()
    {
      Bread thirdBread = new Bread(10);
      Assert.AreEqual(thirdBread.GetPrice(),35);
    }

    [TestMethod]
    public void PasteryConstructor_CreatesInstanceOfBread_Bread()
    {
      Pastry firstPastry = new Pastry(10);
      Assert.AreEqual(typeof(Pastry), firstPastry.GetType());
    }
  }
}