using System;
using Bakery.Models;

namespace Bakery.UI
{
class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("Press any key to get started!");
    Console.ReadKey();

    Console.WriteLine("How many loaves of bread would you like to order?: ");
    string breadInput = Console.ReadLine();
    int breadQuantity = int.Parse(breadInput);

    Console.WriteLine("How many pastries would you like to order?: ");
    string pastryInput = Console.ReadLine();
    int pastryQuantity = int.Parse(pastryInput); 

    Bread bread = new Bread(5.00m, breadQuantity);
    Pastry pastry = new Pastry(2.00m, pastryQuantity);
    decimal orderTotal = bread.CalculateCost() + pastry.CalculateCost();

    Console.WriteLine($"Your total amount due is ${orderTotal:F2}. Thank you for ordering with us!");

    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();

  }
 }
}