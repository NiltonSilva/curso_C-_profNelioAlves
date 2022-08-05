using System;
using System.Globalization;

namespace Aula32_While
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag) {
                Console.Write("Informe um número: ");
                int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (numero >= 0)
                {
                    double raizQuadrada = Math.Sqrt(numero);
                    Console.WriteLine(raizQuadrada.ToString("F3", CultureInfo.InvariantCulture));
                }
                else 
                {
                    Console.WriteLine("Número negativo");
                    flag = false;
                }
            }





        }
    }
}
