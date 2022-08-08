using System;
using System.Globalization;

namespace Aula35_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            // segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
           
            Console.Write("Informe um numero: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++) 
            {
                string[] vetor = Console.ReadLine().Split(' ');

                double num1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                double num2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);

                double media;

                if (num2 != 0) 
                {
                    media = num1 / num2;
                    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
                } else {
                    Console.WriteLine("Divisão impossível");
                }
            }
        }
    }
}
