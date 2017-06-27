using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {//Faça um programa que dado um número digitado pelo usuário, exiba na tela se ele é ou não um número primo.
            int num = 0;
            var divi = new List<int>();
            Console.Write("Informe um número: ");
            num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("Não vou falar de novo, não é dividido por ZERO!");
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        divi.Add(i);
                    }
                }

                if (divi.Count() != 2)
                {
                    Console.WriteLine("Esse número não é primo!");
                }
                else
                {
                    Console.WriteLine("Esse número é primo!");
                }
            }

            Console.ReadKey();
        }
    }
}
