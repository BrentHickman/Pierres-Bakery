using System;

namespace Bakery.Models;

public class Pastry
{
  public int PastryQty { get; set; }
  public int PastryOrderPrice { get; set; }
  private int _pastryPrice;

    public Pastry(int pastryQtyOrdered)
  {
    _pastryPrice = 2;
    PastryQty = pastryQtyOrdered;
    PastryOrderPrice = (pastryQtyOrdered - (pastryQtyOrdered/4))*_pastryPrice;

  }
}