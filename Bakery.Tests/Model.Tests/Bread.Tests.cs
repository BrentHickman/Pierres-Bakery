using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace ShapeTracker.Tests
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
  }
}