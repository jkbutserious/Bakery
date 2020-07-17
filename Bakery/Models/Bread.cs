using System;

namespace Bakery.Models
{
  public class Bread : BakedGood
  {
    public Bread()
    {
      UnitPrice = 5;
    }
    // public double PricePerLoaf { get; set; } = 5;
    public override double Discount
    {
      get
      {
        return Math.Floor(Count / 3.0) * UnitPrice;
      }
    }
    // public double BreadTotal
    // {
    //   get
    //   {
    //     return PricePerLoaf * Count - Discount;
    //   }
    // }
    // public int Count { get; set; }


  }
}