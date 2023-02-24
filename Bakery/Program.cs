using System;
using Bakery.Models;

namespace Bakery.UI
{

  class Program
  {
    static void Main(string[] welcome)
    {
      Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
      Console.WriteLine("    || Welcome To Pierre's!  ||     ");
      Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
      Console.WriteLine("Welcome to Pierre's Perfect Pastries (and Bread!) Bakery!");
      Console.WriteLine("We sell perfect pastries for $2 each or buy 3, get 1 free and perfect bread for $5 each or buy 2, get 1 free!");

      Console.WriteLine("How many loaves of bread would you like to take home with you?");
      int breadQuantity = int.Parse(Console.ReadLine());
      Bread bread = new Bread(breadQuantity);
      int breadTotal = bread.Total();
      Console.WriteLine($"Bread Total: ${breadTotal}");

      Console.WriteLine("How many perfect pastries would you like to bless yourself with?");
      int pastryQuantity = int.Parse(Console.ReadLine());
      Pastry pastry = new Pastry(pastryQuantity);
      int pastryTotal = pastry.Total();
      Console.WriteLine($"Pastry Total: ${pastryTotal}");

      int grandTotal = breadTotal + pastryTotal;
      Console.WriteLine($"Your very fair-priced grand total is : ${grandTotal}");
      Console.WriteLine("Thank you for stopping in! We hope you enjoy your perfect pastries(and bread!)!");
      Console.ReadLine();
    }
  }
}