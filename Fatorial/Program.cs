using System;

namespace Fatorial
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Fatorial\n");
      Console.Write("Insira o valor que deseja saber o Fatorial: ");
      int fatorialDesejado = Int32.Parse(Console.ReadLine());
      // int fatorial = 1;
      // for (int i = 1; i <= fatorialDesejado; i++)
      // {
      //   fatorial *= i;
      //   Console.WriteLine($"Fatorial de {fatorialDesejado}! = {fatorial}");
      // }
      int fatorial = 1;
      for (int i = 1; i <= fatorialDesejado; i++)
      {
        fatorial *= i;
        Console.WriteLine($"{i}! = {fatorial}");
      }
    }
  }
}