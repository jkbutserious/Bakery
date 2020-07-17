using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static Bread CustomerBread = new Bread();
    static Pastries CustomerPastries = new Pastries();
    static void Main(string[] args)
    {
      Console.WriteLine("Bienvenu a Boulangerie de Pierre!");
      Console.WriteLine("Press le 'B' key to add un bread to tu order, et le 'P' key to add un pastry to tu order. When you are finished, press le 'C' key to see your total price, s'il vous plait.");
      var Key = Console.ReadKey(true);
      while (Key.Key != ConsoleKey.C)
      {
        if (Key.Key == ConsoleKey.B)
        {
          CustomerBread.Count++;
          Console.WriteLine("Bread added to cart!");
        }
        if (Key.Key == ConsoleKey.P)
        {
          CustomerPastries.Count++;
          Console.WriteLine("Pastry added to cart!");

        }
        Console.WriteLine($"Total Bread: {CustomerBread.Count}, ${CustomerBread.BreadTotal}");
        Console.WriteLine($"Total Pastries: {CustomerPastries.Count}, ${CustomerPastries.PastriesTotal}");

        Key = Console.ReadKey(true);
      }
      Console.WriteLine("---------------------------------------------------------");
      Console.WriteLine($"Total Discount: -${CustomerBread.Discount + CustomerPastries.Discount}");
      Console.WriteLine($"Total Cost: ${CustomerBread.BreadTotal + CustomerPastries.PastriesTotal}");

    }
  }
}
