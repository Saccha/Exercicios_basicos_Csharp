using System;

namespace exercicios
{
    class Program3
    {
        static void Main(string[] args)
        {
            /*4 – Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: 
                  Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.*/

            double salario = 0;
            double salarioNovo = 0;
            Console.WriteLine("Efetua o reajuste ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Informe o salário: ");
                salario = Convert.ToDouble(Console.ReadLine());
                if(salario <= 300)
                {
                    //50%
                    salarioNovo = salario * 1.50;
                }
                else
                {
                    //30%
                    salarioNovo = salario + ((salario * 30) / 100);
                }
                Console.WriteLine("Salário reajustado: " + salarioNovo);
            }
            Console.ReadKey();
        }
    }
}
