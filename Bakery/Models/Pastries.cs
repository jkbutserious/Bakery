using System;

namespace Bakery.Models
{
  public class Pastries
  {
    public double PricePerPastry { get; set; } = 2;
    public double Discount
    {
      get
      {
        return Math.Floor(Count / 3.0) * (PricePerPastry / 2);
      }
    }
    public double PastriesTotal
    {
      get
      {
        return PricePerPastry * Count - Discount;
      }
    }
    public int Count { get; set; }


  }
}