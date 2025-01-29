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
		
			Console.WriteLine("Digite o terceiro número:");
			int num3 = int.Parse (Console.ReadLine());
			
			if (num1 < num2 && num1 > num3)
			{
				Console.WriteLine("o primeiro número é menor que o segundo número e maior que o terceiro número.");
			}
			else 
			{
			
				Console.WriteLine("Incorreto");
			}
			
				  Console.WriteLine("Aperte qualquer botão para fechar...");
        Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
		}
	}
