using System;

namespace Projeto1
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Digite o primeiro número:");
			int num1 = int.Parse (Console.ReadLine());
				
			Console.WriteLine("Digite o segundo número:");
			int num2 = int.Parse (Console.ReadLine());
		
			if (num1 == num2)
			{
				Console.WriteLine("O números são iguais!");
			}
			else 
			{
			
				Console.WriteLine("O números não são iguais!");
			}
			
				  Console.WriteLine("Aperte qualquer botão para fechar...");
        Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
		}
	}
}
