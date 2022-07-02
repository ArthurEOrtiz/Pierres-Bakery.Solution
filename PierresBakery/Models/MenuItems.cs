using System;

namespace PierresBakery // logic goes here
{
  public class Bread// is the class 
  {
    private int _quantity;
    private int _price;

    public Bread(int quantity)
    {
      _quantity = quantity;

      for (int index = 0; index <= quantity; index++)
      {
        if (!(index % 3 == 0)) {
          _price += 5;
        }
      }
    
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
