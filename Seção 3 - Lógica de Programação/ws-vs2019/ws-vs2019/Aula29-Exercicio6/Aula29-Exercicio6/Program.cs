using System;
using System.Globalization;

namespace Aula29_Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            // seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
            // nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

            Console.Write("Informe um valor: ");
            double numeroLido = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numeroLido >= 0 && numeroLido <= 25)
            {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if (numeroLido > 25 && numeroLido <= 50)
            {
                Console.WriteLine("Intervalo (25, 50]");
            }
            else if (numeroLido > 50 && numeroLido <= 75)
            {
                Console.WriteLine("Intervalo (50, 75]");
            }
            else if (numeroLido > 75 && numeroLido <= 100)
            {
                Console.WriteLine("Intervalo (75, 100]");
            }
            else 
            {
                Console.WriteLine("Fora do intervalo");
            }
        }
    }
}
