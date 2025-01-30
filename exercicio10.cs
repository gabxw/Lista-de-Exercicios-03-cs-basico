using System;

class Program
{
  public static void Main(string[] args)
  {
    Console.Write("Digite um número: ");
    float num1 = float.Parse(Console.ReadLine());

    Console.WriteLine("O resultado é: {0}", num1 % 2);

    Console.Write("Press any key to continue . . . ");
    Console.ReadKey(true);
  }
}