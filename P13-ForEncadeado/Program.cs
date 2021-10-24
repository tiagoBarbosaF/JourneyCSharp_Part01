using System;

namespace P13_ForEncadeado
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("For Encadeado:\n");

      for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
      {
        for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
          Console.Write("*");
        Console.WriteLine();
      }
    }
  }
}