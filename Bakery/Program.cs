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
    ConfirmOrEditBreadOrder(breadOrder);
  }

  static void ConfirmOrEditBreadOrder(Bread breadOrder)
  {
    Console.WriteLine("Does your order look correct?");
    Console.WriteLine($"Order: {breadOrder.BreadQty} loaves of bread for ${breadOrder.BreadOrderPrice}.");
    Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter your bread order");
    string breadOrderCheckInput = Console.ReadLine();
    if (breadOrderCheckInput == "yes" || breadOrderCheckInput == "YES" || breadOrderCheckInput == "Yes" || breadOrderCheckInput == "y" || breadOrderCheckInput == "Y")
    {
      Console.WriteLine("Order Confirmed!");
      Console.WriteLine("Would you like to order some pastries too?");
      string addPastryToBreadOrder = Console.ReadLine();
      if (addPastryToBreadOrder == "yes" || addPastryToBreadOrder == "YES" || addPastryToBreadOrder == "Yes" || addPastryToBreadOrder == "y" || addPastryToBreadOrder == "Y")
      {
        StartPastryOrder();
      }
      else
      {
        Console.WriteLine("Order Placed!");
        Console.WriteLine("It will be ready shortly");
        Console.WriteLine("Thank you and have a great day!");
      }
    }
    else 
    {
      StartBreadOrder();
    }
  }
    static void StartPastryOrder()
  {
    Console.WriteLine("Okay, how many pastries would you like to order?");
    string stringPastryOrderQty = Console.ReadLine();
    int PastryOrderQty = int.Parse(stringPastryOrderQty);
    Pastry pastryOrder = new Pastry(PastryOrderQty);
  }

  static void Checkout()
  {

  }
}