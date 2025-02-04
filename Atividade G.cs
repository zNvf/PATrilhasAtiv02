using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o primero número: ");
float numero = Convert.ToSingle(Console.ReadLine());			
Console.Write("\n\rDigite o segundo número: ");
float numero2 = Convert.ToSingle(Console.ReadLine());			
float resultado = numero2 - numero;			
Console.WriteLine("\n\rA raiz quadrada do número é: " +resultado);
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
