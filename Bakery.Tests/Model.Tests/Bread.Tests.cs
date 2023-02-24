using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadQty_ReturnsBreadQty_Int()
    {
      int breadOrderQty = 3;
      Bread newBreadOrder = new Bread(breadOrderQty);
      int result = newBreadOrder.BreadQty;
      Assert.AreEqual(breadOrderQty, result);
    }
    [TestMethod]
    public void GetBreadQty_CalculatesBreadOrderPrice_Int()
    {
      int breadOrderQty = 1;
      int testBreadOrderPrice = 5;
      Bread newBreadOrder = new Bread(breadOrderQty);
      int result = newBreadOrder.BreadOrderPrice;
      Assert.AreEqual(testBreadOrderPrice, result);
    }
    [TestMethod]
    public void GetBreadQty_CalculatesBreadOrderPriceBOGO_Int()
    {
      int breadOrder1Qty = 2;
      int breadOrder2Qty = 3;
      Bread newBreadOrder1 = new Bread(breadOrder1Qty);
      int result1 = newBreadOrder1.BreadOrderPrice;
      Bread newBreadOrder2 = new Bread(breadOrder2Qty);
      int result2 = newBreadOrder2.BreadOrderPrice;
      Assert.AreEqual(result1, result2);
    }
  }
}
