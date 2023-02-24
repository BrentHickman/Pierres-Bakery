using System;

namespace Bakery.Models;

public class Bread
{
  public int BreadQty { get; set; }
  public int BreadOrderPrice { get; set; }
  private int _loafPrice;
  public Bread(int breadQtyOrdered)
  {
    _loafPrice = 5;
    BreadQty = breadQtyOrdered;
    BreadOrderPrice = (breadQtyOrdered - (breadQtyOrdered/3))*_loafPrice;
  }



}