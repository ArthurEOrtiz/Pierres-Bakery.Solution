using System;
using PierresBakery;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We offer Quality Breads an Pastries.");
      Console.WriteLine("Menu: Bread $5, Pastry $2.");
      Console.WriteLine("Our daily special today:");
      Console.WriteLine("Buy 2 breads get the 3rd for free!");
      Console.WriteLine("Buy 3 pastries for $5!");
      Console.WriteLine("Please enter the quantity of bread you'd like!");
      try 
        {
          string breadInputQuantity = Console.ReadLine();
          int breadQuantity = Int32.Parse(breadInputQuantity);
          Bread newBread = new Bread(breadQuantity);
          Console.WriteLine("Please enter the quantity of pasty you'd like! ");
          string pastryInputQuantity = Console.ReadLine();
          int pastryQuantity = Int32.Parse(pastryInputQuantity);
          Pastry newPastry = new Pastry(pastryQuantity);
          Cart newCart = new Cart(newBread.GetPrice(), newPastry.GetPrice());
          Console.WriteLine("Your total for today is: " + newCart.GetTotal());
          

        }
      catch (FormatException)
        {
          Console.WriteLine("!!!!!!!!Please enter a whole number! Or no bread for you!!!!!!!");
          Main();
        }

      
      // Console.WriteLine("Program is running...");
      // Bread newBread = new Bread(10);
      
      // Pastry newPastry = new Pastry(6);
      // Console.WriteLine(newPastry.GetPrice());
      // Cart newCart = new Cart(newBread.GetPrice(), newPastry.GetPrice());
      // Console.WriteLine(newCart.GetTotal());

    }
  }
}