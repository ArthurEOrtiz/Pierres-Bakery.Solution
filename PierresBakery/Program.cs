using System;
using PierresBakery;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Program is running...");
      Bread newBread = new Bread(10);
      Console.WriteLine(newBread.GetPrice()); 

    }
  }
}