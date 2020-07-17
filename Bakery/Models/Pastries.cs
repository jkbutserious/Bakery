using System;

namespace Bakery.Models
{
  public class Pastries : BakedGood
  {
    public Pastries()
    {
      UnitPrice = 2;
    }
    // public double PricePerPastry { get; set; } = 2;
    public override double Discount => Math.Floor(Count / 3.0) * (UnitPrice / 2);
    // public double PastriesTotal
    // {
    //   get
    //   {
    //     return PricePerPastry * Count - Discount;
    //   }
    // }
    // public int Count { get; set; }


  }
}