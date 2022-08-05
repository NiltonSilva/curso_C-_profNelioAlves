using System;

namespace Aula30_Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.Write("Informe 3 números inteiros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine($"O 1º número digitado ({n1}) é o maior");
            //}
            //else if (n2 > n1 && n2 > n3)
            //{
            //    Console.WriteLine($"O 2º número digitado ({n2}) é o maior");
            //}
            //else 
            //{
            //    Console.Write($"O 3º número digitado ({n3}) é o maior");
            //}

            double resultado = Maior(n1, n2, n3);
            Console.Write("Maior = " + resultado);
        }

        static int Maior(int a, int b, int c) {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else 
            {
                return c;
            }
        }
    }
}
