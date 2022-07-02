using System;

namespace PierresBakery
{
  public class Bread
  {
    private int _quantity;
    private int _price;

    public Bread(int quantity)
    {
      _quantity = quantity;

      for (int index = 1; index <= quantity; index++)
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
  public class Pastry
  {
    private int _quantity;
    private int _price; 

    public Pastry(int quantity)
    {
      _quantity = quantity;

      for (int index = 1; index <= quantity; index++)
      {
        if (!(index % 3 == 0)) {
          _price += 2;
        }
        else
        {
          _price ++;
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

  public class Cart 
  {
    private int _total;

    public Cart(int breadCost, int pastryCost)
    {
      _total = breadCost + pastryCost;
    }

    public int GetTotal() 
    {
      return _total;
    }
  }
}
