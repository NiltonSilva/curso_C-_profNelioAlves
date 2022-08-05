using System;
using System.Globalization;

namespace Aula34_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quandos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            double soma = 0;

            for (int i = 0; i < n; i++) {
                Console.Write($"Informe o {i+1}º valor: ");
                double numeroDigitado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += numeroDigitado;
            }

            Console.WriteLine("A soma dos números é = " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
