using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static Bread Bread = new Bread();
    static Pastries Pastries = new Pastries();
    static void Main(string[] args)
    {
      Console.WriteLine("Bienvenu a Boulangerie de Pierre!");
      Console.WriteLine("Press le 'B' key to add un bread to tu order, et le 'P' key to add un pastry to tu order. When you are finished, press le 'C' key to see your total price, s'il vous plait.");
      var Key = Console.ReadKey(true);
      while (Key.Key != ConsoleKey.C)
      {
        if (Key.Key == ConsoleKey.B)
        {
          Bread.Count++;
          Console.WriteLine("Bread added to cart!");
        }
        if (Key.Key == ConsoleKey.P)
        {
          Pastries.Count++;
          Console.WriteLine("Pastry added to cart!");

        }
        Console.WriteLine($"Total Bread: {Bread.Count}, ${Bread.BreadTotal}");
        Console.WriteLine($"Total Pastries: {Pastries.Count}, ${Pastries.PastriesTotal}");

        Key = Console.ReadKey(true);
      }
      Console.WriteLine($"Total Discount: -${Bread.Discount + Pastries.Discount}");
      Console.WriteLine($"Total Cost: ${Bread.BreadTotal + Pastries.PastriesTotal}");

    }
  }
}
