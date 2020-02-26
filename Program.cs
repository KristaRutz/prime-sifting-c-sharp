using System;
using System.Collections.Generic;
using PrimeSifter.Prime;

namespace PrimeSifter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number:");
      int input = int.Parse(Console.ReadLine());
      Number primes = new Number(input);
      Console.WriteLine(primes.GetList());
    }
  }
}