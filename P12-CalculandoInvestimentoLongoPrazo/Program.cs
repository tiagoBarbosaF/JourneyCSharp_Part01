using System;

namespace P12_CalculandoInvestimentoLongoPrazo
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Calculando rendimentos:\n");
      Console.Write("Insira o valor que deseja investir: ");
      double valorInvestido = Double.Parse(Console.ReadLine());

      Console.Write("\nInsira quantos anos deseja que seu dinheiro renda: ");
      int anosInvestidos = Int32.Parse(Console.ReadLine());
      int contadorMes, contadorAno;
      double fatorRendimento = 1.005;

      for (contadorAno = 1; contadorAno < anosInvestidos; contadorAno++)
      {
        for (contadorMes = 1; contadorMes < 12; contadorMes++)
        {
          valorInvestido *= fatorRendimento;
          Console.WriteLine($"Após {contadorMes} mês do ano {contadorAno}, seu valor investido será R$ {valorInvestido:F2}");
        }

        Console.WriteLine($"Ao final do ano {contadorAno}, o valor Investido estará com: R$ {valorInvestido:F2}");
        Console.WriteLine($"Fator de rendimento deste ano foi de: {fatorRendimento}\n");
        fatorRendimento += 0.001;
      }

      Console.WriteLine($"\nTempo de investimento foi de {anosInvestidos} anos.");
      Console.WriteLine($"Ao término do investimento, você terá R$ {valorInvestido:F2}");
    }
  }
}