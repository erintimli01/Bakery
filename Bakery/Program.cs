using System;
using Bakery.Models;

namespace Bakery.UI
{

  class Program
  {
    static void Main(string[] welcome)
    {
      Console.WriteLine("Welcome to Pierre's Perfect Pastries and Bread Bakery!");
      Console.WriteLine("We sell perfect pastries for $2 each or buy 3, get 1 free and perfect bread for $5 each or buy 2, get 1 free!");

      Console.WriteLine("How many loaves of bread would you like to take home with you?");
      int breadQuantity = int.Parse(Console.ReadLine());

    }
   //UI goes here
  }
}
}