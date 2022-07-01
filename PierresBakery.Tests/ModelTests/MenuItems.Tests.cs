using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class MenuItemsTests
  {
    [TestMethod]
    public void BreadList_ReturnListOfBread_BreadListItems()
    {
      List<string> testBreadList = new List<string> {"White", "Multigrain", "Ciabatta", "Focaccia", "Rye"};
      Assert.AreEqual(testBreadList, MenuItems.listOfBreads);
    }
  }
}