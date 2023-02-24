using System;

namespace Bakery.Models;

public class Pastry
{
  public int PastryQty { get; set; }

    public Pastry(int pastryQtyOrdered)
  {
    PastryQty = pastryQtyOrdered;
  }
}