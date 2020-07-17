using System;

namespace Bakery.Models
{
  public class Order
  {
    public int Loaves { get; set; }
    public int Pastries { get; set ; }

    public Order(int loaves, int pastries)
    {
      Loaves = loaves;
      Pastries = pastries;
    }
  }
}