using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o número: ");
int numero = Convert.ToInt32(Console.ReadLine());
int resto = numero % 2;			
Console.WriteLine("\n\rO resto da divisão do " +numero+" por 2 é: " +resto);
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
