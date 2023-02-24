using System;

namespace Bakery.Models;

public class Bread
{
  public int BreadQty { get; set; }
  public int BreadOrderPrice { get; set; }
  private int _loafprice;
  public Bread(int breadQtyOrdered)
  {
    _loafprice = 5;
    BreadQty = breadQtyOrdered;
    BreadOrderPrice = (breadQtyOrdered - (breadQtyOrdered/3))*_loafprice;
  }



}