using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryQty_ReturnsPastryQty_Int()
    {
      int pastryOrderQty = 4;
      Bread newPastryOrder = new Bread(pastryOrderQty);
      int result = newPastryOrder.PastryQty;
      Assert.AreEqual(pastryOrderQty, result);
    }
    // [TestMethod]
    // public void GetBreadQty_CalculatesBreadOrderPrice_Int()
    // {
    //   int breadOrderQty = 1;
    //   int testBreadOrderPrice = 5;
    //   Bread newBreadOrder = new Bread(breadOrderQty);
    //   int result = newBreadOrder.BreadOrderPrice;
    //   Assert.AreEqual(testBreadOrderPrice, result);
    // }
  //   [TestMethod]
  //   public void GetBreadQty_CalculatesBreadOrderPriceBOGO_Int()
  //   {
  //     int breadOrder1Qty = 2;
  //     int breadOrder2Qty = 3;
  //     Bread newBreadOrder1 = new Bread(breadOrder1Qty);
  //     int result1 = newBreadOrder1.BreadOrderPrice;
  //     Bread newBreadOrder2 = new Bread(breadOrder2Qty);
  //     int result2 = newBreadOrder2.BreadOrderPrice;
  //     Assert.AreEqual(result1, result2);
  //   }
  }
}
