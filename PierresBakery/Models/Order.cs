using System.Collections.Generic;
using System;

namespace PierresBakery
{
  public class Order
  {
    public string Title { get; set; }
  
    public Order(string title)
    {
      Title = title;
    }
  }
}