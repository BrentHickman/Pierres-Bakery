using System;

namespace Bakery.Models;

public class Bread
{
  public int BreadQty { get; set; }
  public Bread(int breadQtyOrdered)
  {
    BreadQty = breadQtyOrdered;
  }



}