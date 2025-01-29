using System;

namespace Projeto1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());
                
      	Console.WriteLine("Digite o segundo número:");
            int num2 = int.Parse(Console.ReadLine());
           
            int diferenca = num1 - num2;
            
           if (diferenca <= 10)
          
            {
                Console.WriteLine("A diferença entre os números é menor que 10");
            }
            else
            {
                Console.WriteLine("A diferença entre os número é maior ou igual a 10");
            }
            
            Console.WriteLine("Aperte qualquer botão para fechar...");
            Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
        }
    }
}
