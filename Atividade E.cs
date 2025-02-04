using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o dividendo: ");
float dividendo = Convert.ToSingle(Console.ReadLine());			
Console.Write("Digite o divisor: ");
float divisor = Convert.ToSingle(Console.ReadLine());			
float quociente = dividendo / divisor;			
Console.WriteLine();
Console.WriteLine("A divisão dos números é: " +quociente);
Console.WriteLine();
Console.WriteLine("Aperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
