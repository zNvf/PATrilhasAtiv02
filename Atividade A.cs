using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o primeiro número: ");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o segundo número: ");
int numero2 = Convert.ToInt32(Console.ReadLine());	
int soma = numero1 + numero2;			
Console.WriteLine();
Console.WriteLine("A soma dos números é: " +soma);
Console.WriteLine();
Console.WriteLine("Aperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
