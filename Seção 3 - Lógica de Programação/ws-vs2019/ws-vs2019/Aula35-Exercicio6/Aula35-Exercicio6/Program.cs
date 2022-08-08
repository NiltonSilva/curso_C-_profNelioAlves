using System;

namespace Aula35_Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler um número inteiro N e calcular todos os seus divisores.
            Console.Write("Informe um número para saber seus divisores: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++) {
                if (numero % i == 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
