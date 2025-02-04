using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o número: ");
float numero = Convert.ToSingle(Console.ReadLine());			
float valorabs = Convert.ToSingle(Math.Abs(numero));			
Console.WriteLine("\n\rO valor de " +numero+ " é: " +valorabs);
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
