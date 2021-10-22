using System;

namespace MultiplosDeTres
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Multiplos de 3\n");

      for (int i = 1; i <= 100; i++)
      {
        if (i % 3 == 0)
        {
          Console.Write($"{i}, ");
        }
      }
    }
  }
}