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
    [TestMethod]
    public void PastryConstructor_ReturnsValueOfPrice_Ten()
    {
      Pastry secondPastry = new Pastry(6);
      Assert.AreEqual(secondPastry.GetPrice(), 10);
    }

    [TestMethod]
    public void CartConstructor_ReturnTotalCost_fourtyfive()
    {
      Bread fourthBread = new Bread(10);
      Pastry thirdPastry = new Pastry(6);
      Cart firstCart = new Cart(fourthBread.GetPrice(), thirdPastry.GetPrice());
      Assert.AreEqual(firstCart.GetTotal(), 45);
    }
  }
}