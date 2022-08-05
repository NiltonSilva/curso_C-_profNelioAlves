using System;
using System.Globalization;

namespace Aula29_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.A seguir, calcule e mostre o valor da conta a pagar.
            int codigo = 0;
            int quantidade = 0;
            double valorProduto = 0.0;
            double valorAPagar = 0.0;

            // ENTRADA DOS DADOS
            Console.Write("Informe o código do produto e a quantidade: ");
            string[] vetor = Console.ReadLine().Split(' ');
            codigo = int.Parse(vetor[0]);
            quantidade = int.Parse(vetor[1]);

            // PROCESSAMENTO DOS DADOS
            if (codigo == 1)
            {
                valorAPagar = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                valorAPagar = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                valorAPagar = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                valorAPagar = quantidade * 2.0;
            }
            else {
                valorAPagar = quantidade * 1.5;
            }

            // SAÍDA DOS DADOS
            Console.WriteLine("Total: R$ " + valorAPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
