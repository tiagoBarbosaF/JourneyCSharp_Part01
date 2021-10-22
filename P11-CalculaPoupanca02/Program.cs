using System;

namespace P11_CalculaPoupanca02
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Calculando rendimentos:\n");
      Console.Write("Insira o valor que deseja investir: ");
      double valorInvestido = Double.Parse(Console.ReadLine());

      Console.Write("\nInsira quantos meses deseja ver quanto rende seu dinheiro: ");
      int mesesInvestidos = Int32.Parse(Console.ReadLine());

      for (int contadorMes = 1; contadorMes < mesesInvestidos; contadorMes++)
      {
        valorInvestido *= 1.005;
        Console.WriteLine($"Após {contadorMes} mês, seu valor investido será R$ {valorInvestido:F2}");
      }
    }
  }
}