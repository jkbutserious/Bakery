using System;
using Order;

namespace Bakery.Models
{
  public class Bread
  {
    public int AddBreadToOrder(int userLoaves)
    {
      Order.Loaves = userLoaves;
      return Order.Loaves;
    }
  }
}