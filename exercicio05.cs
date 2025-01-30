using System;

class Program
{
  public static void Main(string[] args)
  {
    Console.Write("Digite um número: ");
    float num1 = float.Parse(Console.ReadLine());
    Console.Write("Digite outro número: ");
    float num2 = float.Parse(Console.ReadLine());

    Console.WriteLine("O resultado é: {0}", num1 / num2);

    Console.Write("Press any key to continue . . . ");
    Console.ReadKey(true);
  }
}