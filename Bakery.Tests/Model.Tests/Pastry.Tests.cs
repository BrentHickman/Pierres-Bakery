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
      Pastry newPastry = new Pastry(4);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryQty_ReturnsPastryQty_Int()
    {
      int pastryOrderQty = 4;
      Pastry newPastryOrder = new Pastry(pastryOrderQty);
      int result = newPastryOrder.PastryQty;
      Assert.AreEqual(pastryOrderQty, result);
    }
    [TestMethod]
    public void GetPastryQty_CalculatesPastryOrderPrice_Int()
    {
      int pastryOrderQty = 1;
      int testPastryOrderPrice = 2;
      Pastry newPastryOrder = new Pastry(pastryOrderQty);
      int result = newPastryOrder.PastryOrderPrice;
      Assert.AreEqual(testPastryOrderPrice, result);
    }
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
