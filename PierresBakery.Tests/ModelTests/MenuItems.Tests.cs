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
      Bread firstBread = new Bread(1, 1);
      Assert.AreEqual(typeof(Bread), firstBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_ReturnsValueOfPrice_One()
    {
      Bread secondBread = new Bread(1,1);
      Assert.AreEqual(secondBread.GetPrice(), 1);
    } 

    [TestMethod]
    public void BreadConstructor_ReturnsValueOfQuantity_One()
    {
      Bread thirdBread = new Bread(1,1);
      Assert.AreEqual(thirdBread.GetPrice(),1);
    }

  }
}