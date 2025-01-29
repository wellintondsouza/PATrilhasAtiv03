using System;

namespace Projeto1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite o primeiro número:");
            float num1 = float.Parse(Console.ReadLine());
                
      
            if (num1 >= 0)
            {
                Console.WriteLine("O número é positivo");
            }
            else
            {
                Console.WriteLine("O número é negativo");
            }
            
            Console.WriteLine("Aperte qualquer botão para fechar...");
            Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
        }
    }
}
