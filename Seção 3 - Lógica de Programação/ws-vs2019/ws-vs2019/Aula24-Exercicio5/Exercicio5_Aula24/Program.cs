using System;
using System.Globalization;

namespace Exercicio5_Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.

            int codigoPeca1, qtdPecas1, codigoPeca2, qtdPecas2;
            double valorUnitario1, valorUnitario2, valorTotal1, valorTotal2, valorTotalFinal;

            Console.Write("Informe o código da peça, a quantidade de peças e o valor unitário das peças (1): ");
            string[] vetor1 = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(vetor1[0]);
            qtdPecas1 = int.Parse(vetor1[1]);
            valorUnitario1 = double.Parse(vetor1[2], CultureInfo.InvariantCulture);
            valorTotal1 = qtdPecas1 * valorUnitario1;

            Console.Write("Informe o código da peça, a quantidade de paças e o valor unitário das peças (2): ");
            string[] vetor2 = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(vetor2[0]);
            qtdPecas2 = int.Parse(vetor2[1]);
            valorUnitario2 = double.Parse(vetor2[2], CultureInfo.InvariantCulture);
            valorTotal2 = qtdPecas2 * valorUnitario2;

            valorTotalFinal = valorTotal1 + valorTotal2;

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotalFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
