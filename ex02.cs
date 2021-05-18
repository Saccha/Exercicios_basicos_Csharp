using System;

namespace exercicios
{
    class Program1
    {
        static void Main(string[] args)
        {
            /*2 - Crie um algoritmo que verifique se um número informado é par ou impar*/

            int x = 0;
            int y = 0;
            Console.WriteLine("Determinar se o número é par ou ímpar");
            Console.Write("Informe um número: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = x % 2;
            if (y == 1)
            {
                Console.WriteLine("O número informado é ímpar");
            }
            else
            {
                Console.WriteLine("O número informado é par");
            }
            Console.ReadKey();
        }
    }
}
