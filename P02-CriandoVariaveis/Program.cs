using System;

namespace P02_CriandoVariaveis
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Executando projeto 2 - Criando variáveis");

      int idade = 32;

      Console.WriteLine(idade);

      idade = 10;
      Console.WriteLine(idade);

      idade = 10 + 5;
      Console.WriteLine(idade);

      idade = 10 + 5 * 2;
      Console.WriteLine(idade);

      idade = (10 + 5) * 2;
      Console.WriteLine(idade);

      Console.WriteLine("Sua idade é " + idade +"!");
    }
  }
}
