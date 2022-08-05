using System;

namespace Exercicio1_Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.
            Console.Write("Informe o primeiro número: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            int number2 = int.Parse(Console.ReadLine());

            int sum = number1 + number2;

            Console.Write("A soma dos numeros é: " + sum);
        }
    }
}
