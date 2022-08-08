using System;

namespace Aula35_Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um numero inteiro e positivo: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++) 
            {
                Console.WriteLine($"{Math.Pow(i, 1)} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
    }
}
