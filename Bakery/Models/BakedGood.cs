using System;

namespace Bakery.Models
{
  public abstract class BakedGood
  {
    public double UnitPrice { get; set; }
    public abstract double Discount { get; }
    public double Total
    {
      get
      {
        return UnitPrice * Count - Discount;
      }
    }
    public int Count { get; set; }


  }
}