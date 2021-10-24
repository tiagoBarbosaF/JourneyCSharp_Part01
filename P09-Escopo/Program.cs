using System;

namespace P09_Escopo
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Executando projeto 9 - Escopo\n");

      int idadeJoao = 20;
      int quantidadePessoas = 3;
      bool acompanhado = (quantidadePessoas >= 2) ? true : false;

      if (idadeJoao >= 18 || acompanhado)
      {
        Console.WriteLine("Seja bem vindo!");
      }
      else
      {
        Console.WriteLine("Infelizmente você não pode entrar.");
      }
    }
  }
}