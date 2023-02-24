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
        Console.WriteLine("Have a great day!");
      }
  }
  static void BeginOrder()
  {
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

  }
    static void StartPastryOrder()
  {

  }

}