using System;
using System.Collections.Generic;

namespace PrimeSifter.Prime
{
  public class Number
  {
    private int _input;
    private List<int> _numbers = new List<int> ();

    public Number(int input)
    {
      _input = input;
      SetList();
      GetPrimes();
    }

    public void SetList()
    {
      for (int i = 2; i <= _input; i++)
      {
        _numbers.Add(i);
      }
    }

    public string GetList()
    {
      string list = "These are your numbers: ";
      foreach (int item in _numbers)
      {
        list += item.ToString() + " ";
      }
      return list;
    }

    public void GetPrimes()
    {
      for (int index = 0; index < _numbers.Count; index++)
      {
        for (int num = 2; num <= _input; num++)
        {
          if (num % _numbers[index] == 0 && num != _numbers[index])
          {
            _numbers.Remove(num);
          }
        }
      }
    }

  }
}