using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o número: ");
int numero1 = Convert.ToInt32(Console.ReadLine());
int resultado = numero1 / 2;			
Console.WriteLine();
Console.WriteLine("O dobro do número é: " +resultado);
Console.WriteLine();
Console.WriteLine("Aperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
