using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o número: ");
float numero = Convert.ToSingle(Console.ReadLine());			
float raizquadrada = Convert.ToSingle(Math.Sqrt(numero));
Console.WriteLine("\n\rA raiz quadrada do número é: " +raizquadrada);
Console.WriteLine("\n\rAperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
