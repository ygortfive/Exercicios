using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {//Faça um programa que exiba na tela todos os divisores de um número digitado pelo usuário.

            int num = 0;
            Console.Write("Informe um número: ");
            num = int.Parse(Console.ReadLine());            
            if (num == 0)
            {
                Console.Write("Zero não é divisor de nada, poha!");
            }
            else
            {
                Console.Write("Números divisores de " + num + " são: ");
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
