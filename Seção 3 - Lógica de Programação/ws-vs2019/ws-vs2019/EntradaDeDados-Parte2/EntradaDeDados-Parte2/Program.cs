using System;
using System.Globalization;

namespace EntradaDeDados_Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o número {n1}.");

            Console.Write("Informe um caractere: ");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o caractere {ch}.");

            Console.Write("Informe um número double: ");
            double n2 = double.Parse(Console.ReadLine());   // Do jeito que está aqui devo digitar (no console) virgula em vez de ponto, caso contrário exibirá um número inteiro.
            Console.WriteLine($"Você digitou o número {n2}.");

            Console.WriteLine("Informe os dados da Maria: ");
            string[] vetor = Console.ReadLine().Split(' '); // Com esse comando já recebo todas as informações da Maria, recorto e cada espaço e coloco no vetor.
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3]);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);


        }
    }
}
