using System;

namespace P08_Condicionais02
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Executando projeto 8 - Condicionais 02:");

      int idadeJoao = 16;
      int quantidadePessoas = 2;
      bool acompanhado = quantidadePessoas >= 2;

      if (idadeJoao >= 18 && acompanhado)
      {
        Console.WriteLine("Pode entrar.");
      }
      else
      {
        Console.WriteLine("Não pode entrar.");
      }
    }
  }
}