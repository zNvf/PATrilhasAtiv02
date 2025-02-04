using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o primeiro número: ");
float numero = Convert.ToSingle(Console.ReadLine());			
Console.Write("Digite o segundo número: ");
float numero2 = Convert.ToSingle(Console.ReadLine());			
float multiplicacao = numero2 * numero;			
Console.WriteLine("\n\rA multiplicação dos números " +numero+" e " +numero2+ " é: " +multiplicacao);
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
