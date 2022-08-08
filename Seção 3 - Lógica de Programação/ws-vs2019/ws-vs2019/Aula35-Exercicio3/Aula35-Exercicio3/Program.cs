using System;
using System.Globalization;

namespace Aula35_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            // de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
            // conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            // peso 5.

            double primNum, segNum, terNum, media;

            Console.Write("Informe o numero de vezes: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++) 
            {
                string[] line = Console.ReadLine().Split(' ');
                primNum = double.Parse(line[0], CultureInfo.InvariantCulture);
                segNum = double.Parse(line[1], CultureInfo.InvariantCulture);
                terNum = double.Parse(line[2], CultureInfo.InvariantCulture);

                media = (primNum * 2.0 + segNum * 3.0 + terNum * 5.0) / 10.0;

                Console.WriteLine("Media " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
