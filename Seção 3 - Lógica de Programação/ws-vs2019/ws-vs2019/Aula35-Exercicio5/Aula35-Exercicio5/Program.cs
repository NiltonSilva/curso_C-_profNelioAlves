using System;

namespace Aula35_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... *1.
            // Lembrando que, por definição, fatorial de 0 é 1.

            int fatorial = 1;

            Console.Write("Informe o valor: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++) 
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
