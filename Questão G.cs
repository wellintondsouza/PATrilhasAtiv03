using System;

namespace Projeto1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite o primeiro número:");
            float num1 = float.Parse(Console.ReadLine());
                
            Console.WriteLine("Digite o segundo número:");
            float num2 = float.Parse(Console.ReadLine());
        
            if (num1 < num2)
            {
                Console.WriteLine("O primeiro número é menor que o segundo");
            }
            else if (num1 > num2) 
            {
                Console.WriteLine("O primeiro número é maior que o segundo");
            }
            else // Se não for maior nem menor, então são iguais
            {
                Console.WriteLine("O primeiro número é igual ao segundo");
            }
            
            Console.WriteLine("Aperte qualquer botão para fechar...");
            Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
        }
    }
}
