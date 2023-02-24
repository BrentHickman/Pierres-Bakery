using System;

namespace Bakery.Models;

public class Bread
{
  public int BreadQty { get; set; }
  public int BreadOrderPrice { get; set; }

  public Bread(int breadQtyOrdered)
  {
    BreadQty = breadQtyOrdered;
    BreadOrderPrice = CalcBreadOrderPrice(breadQtyOrdered);
  }

  public int CalcBreadOrderPrice(int breadQtyOrdered)
  {
    int loafPrice = 5;
    this.BreadOrderPrice = (breadQtyOrdered - (breadQtyOrdered/3))*loafPrice;
    return BreadOrderPrice;
  }


}