using System;
using PierresBakery;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Program is running...");
      Bread newBread = new Bread(1, 1);
      Console.WriteLine(newBread); // this outputs PierresBakkery.Bread
      Console.WriteLine(newBread.GetPrice()); // this returns 1
      Console.WriteLine(newBread.GetQuantity()); // this returns 1
    }
  }
}