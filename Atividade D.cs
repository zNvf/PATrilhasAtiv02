using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o número: ");
int numero1 = Convert.ToInt32(Console.ReadLine());			
int quadrado = numero1 * numero1;			
Console.WriteLine();
Console.WriteLine("O dobro do número é: " +quadrado);
Console.WriteLine();
Console.WriteLine("Aperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
