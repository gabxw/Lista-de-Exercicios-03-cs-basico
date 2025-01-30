using System;

class Program
{
  public static void Main(string[] args)
  {
    Console.Write("Digite um número: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite outro número: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("O resultado da soma é: {0}", num1 - num2);

    Console.Write("Press any key to continue . . . ");
    Console.ReadKey(true);
  }
}