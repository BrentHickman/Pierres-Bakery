using System;
using Bakery;

namespace Bakery.Models;

class Program
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("Whould you like to place an order?");
    Console.WriteLine("Yes or No?");
    string stringBeginOrder = Console.ReadLine();
    if (stringBeginOrder == "yes" || stringBeginOrder == "Yes" || stringBeginOrder == "YES" || stringBeginOrder == "y" || stringBeginOrder == "Y")
      {
        BeginOrder();
      } 
    else 
      {
        Console.WriteLine("Come back soon!");
      }
  }
  static void BeginOrder()
  {
    Console.Clear();
    Console.WriteLine("What would you like to order?");
    Console.WriteLine("'Bread' or 'Pastry'");
    string stringOrderType = Console.ReadLine();
    if (stringOrderType == "Bread" || stringOrderType == "bread")
      {
        StartBreadOrder();
      } 
    else if (stringOrderType == "Pastry" || stringOrderType == "pastry") 
      {
        StartPastryOrder();
      }
    else 
      {
        Console.WriteLine("Please type either 'Bread' or 'Pastry'");
        BeginOrder();
      }
  }
  
  static void StartBreadOrder()
  {
    Console.WriteLine("Okay, how many loaves of bread would you like to order?");
    string stringBreadOrderQty = Console.ReadLine();
    int breadOrderQty = int.Parse(stringBreadOrderQty);
    Bread breadOrder = new Bread(breadOrderQty);
  }
    static void StartPastryOrder()
  {
    Console.WriteLine("Okay, how many pastries would you like to order?");
    string stringPastryOrderQty = Console.ReadLine();
    int PastryOrderQty = int.Parse(stringPastryOrderQty);
    Pastry pastryOrder = new Pastry(PastryOrderQty);
  }

}