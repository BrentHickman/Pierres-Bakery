using System;

namespace Bakery.Models;

public class Pastry
{
  public int PastryQty { get; set; }
  public int PastryOrderPrice { get; set; }
    public Pastry(int pastryQtyOrdered)
  {
    PastryQty = pastryQtyOrdered;
    PastryOrderPrice = CalcBreadOrderPrice(pastryQtyOrdered);
  }
  public int CalcBreadOrderPrice(int pastryQtyOrdered)
  {
    int pastryPrice = 2;
    this.PastryOrderPrice = (pastryQtyOrdered - (pastryQtyOrdered/4))*pastryPrice;
    return PastryOrderPrice;
  }
}