using System;

namespace Bakery.Models
{
  public class Pastries : BakedGood
  {
    public Pastries()
    {
      UnitPrice = 2;
    }
    public override double Discount => Math.Floor(Count / 3.0) * (UnitPrice / 2);
  }
}