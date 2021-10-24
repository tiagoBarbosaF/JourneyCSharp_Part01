using System;

namespace AliquotasIR
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Aliquota Imposto de Renda:\n");
      double salario = 3300.0D;
      double deducao = 0;
      double aliquota = 0;
      
      if (salario >= 1900 && salario <=2800)
      {
        aliquota = 7.5;
        deducao = salario * (aliquota / 100);
      } else if (salario > 2800 && salario <= 3751)
      {
        aliquota = 15;
        deducao = salario * (aliquota / 100);
      } else if (salario > 3751 && salario < 4664)
      {
        aliquota = 22.5;
        deducao = salario * (aliquota / 100);
      }

      Console.WriteLine("Seu salário é " + salario + ", teve aliquota de " + aliquota + " e dedução de " + deducao);
      Console.WriteLine("Seu salário atual é " + (salario - deducao));
    }
  }
}