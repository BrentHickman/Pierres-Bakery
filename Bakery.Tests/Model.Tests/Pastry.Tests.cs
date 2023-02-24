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
    [TestMethod]
    public void GetPastryQty_CalculatesPastryOrderPriceBOGO_Int()
    {
      int pastryOrder1Qty = 3;
      int pastryOrder2Qty = 4;
      Pastry newPastryOrder1 = new Pastry(pastryOrder1Qty);
      int result1 = newPastryOrder1.PastryOrderPrice;
      Pastry newPastryOrder2 = new Pastry(pastryOrder2Qty);
      int result2 = newPastryOrder2.PastryOrderPrice;
      Assert.AreEqual(result1, result2);
    }
  }
}
//
