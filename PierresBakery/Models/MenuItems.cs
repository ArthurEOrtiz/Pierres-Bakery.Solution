using System;

namespace PierresBakery // logic goes here
{
  public class Bread// is the class 
  {
    private int _quantity;
    private int _price;
    // in here  goes the method.
    public Bread(int quantity, int price)
    {
      _quantity = quantity;
      _price = price;

    }

    public int GetQuantity()
    {
      return _quantity;
    }

    public int GetPrice()
    {
      return _price;
    }
  
  }
}
