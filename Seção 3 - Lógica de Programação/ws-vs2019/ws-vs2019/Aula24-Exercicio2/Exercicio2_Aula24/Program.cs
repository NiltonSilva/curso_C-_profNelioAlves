using System;
using System.Globalization;

namespace Exercicio2_Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
            // Fórmula da área: area = π.raio²
            // Considere o valor de π = 3.14159

            Console.Write("Informe o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = /*Math.PI*/ 3.14159 * Math.Pow(raio, 2);
            Console.WriteLine("Valor da área: " + area.ToString("F4", CultureInfo.InvariantCulture));
           
        }
    }
}
