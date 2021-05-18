using System;

namespace exercicios
{
    class Program2
    {
        static void Main(string[] args)
        {
            /*3 - Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.*/

            int qtde = 0;
            int idade = 0;
            Console.WriteLine("Verificar quem é maior de idade");
            int i = 0;
            while (i < 10)
            {
                i += 1;
                Console.Write("Informe a idade da pessoa: ");
                if (idade >= 18)
                {
                    qtde += 1;
                }
            }
            Console.WriteLine("Existem " + qtde + " pessoa com mais de 18 anos");
            Console.ReadKey();
        }
    }
}
