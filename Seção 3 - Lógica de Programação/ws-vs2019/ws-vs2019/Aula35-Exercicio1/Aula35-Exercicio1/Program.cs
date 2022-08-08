using System;

namespace Aula35_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor de 1 a 1000: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++) 
            {
                if (i % 2 != 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
