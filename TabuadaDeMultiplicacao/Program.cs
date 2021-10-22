using System;

namespace TabuadaDeMultiplicacao
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Tabuada de Multiplicação\n");

      int multiplicador = 1;
      int contador = 1;

      for (multiplicador = 1; multiplicador < 10; multiplicador++)
      {
        Console.WriteLine($"Tabuada de {multiplicador}");
        for (contador = 0; contador <= 10; contador++)
        {
          Console.Write($"{multiplicador} * {contador} = {multiplicador * contador}");
          Console.WriteLine();
        }

        Console.WriteLine();
      }
    }
  }
}