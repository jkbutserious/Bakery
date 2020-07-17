using System;

namespace Bakery.Models
{
  public class Bread
  {
    public double PricePerLoaf { get; set; } = 5;
    public double Discount
    {
      get
      {
        return Math.Floor(Count / 3.0) * PricePerLoaf;
      }
    }
    public double BreadTotal
    {
      get
      {
        return PricePerLoaf * Count - Discount;
      }
    }
    public int Count { get; set; }


  }
}