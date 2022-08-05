using System;

namespace Aula31_Funcoes
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

            double resultado = Maior(n1, n2, n3);
            Console.Write("Maior = " + resultado);
        }

        static int Maior(int a, int b, int c)
        {
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
