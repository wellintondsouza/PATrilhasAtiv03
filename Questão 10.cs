using System;

namespace Projeto1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite o primeiro número:"); //Permite digitar um número
            int num1 = int.Parse(Console.ReadLine());
                
            if (num1 == 0) //Calculo da diferença do número 0
           
            {
                Console.WriteLine("O número é igual a zero");
            }
            else
            {
                Console.WriteLine("O número é diferente de zero");
            }
            
            Console.WriteLine("Aperte qualquer botão para fechar...");
            Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
        }
    }
}
