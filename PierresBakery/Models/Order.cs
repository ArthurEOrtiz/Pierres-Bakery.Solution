using System.Collections.Generic;
using System;

namespace PierresBakery
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
  
    public Order(string title, string description, double price)
    {
      Title = title;
      Description = description;
      Price = price;
    }
  }
}