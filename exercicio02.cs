using System;

class Program
{
  public static void Main(string[] args)
  {
    Console.Write("Digite um número: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("O resultado é: {0}", num1 * 2);

    Console.Write("Press any key to continue . . . ");
    Console.ReadKey(true);
  }
}