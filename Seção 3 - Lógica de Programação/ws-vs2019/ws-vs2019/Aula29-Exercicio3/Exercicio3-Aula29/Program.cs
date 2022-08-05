using System;

namespace Exercicio3_Aula29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.

            int num1, num2;

            Console.Write("Informe dois números: ");
            string[] vetor = Console.ReadLine().Split(' ');
            num1 = int.Parse(vetor[0]);
            num2 = int.Parse(vetor[1]);

            if (num1 > num2)
            {
                if (num1 % num2 == 0)
                {
                    Console.WriteLine("São Múltiplos");
                }
                else
                {
                    Console.WriteLine("Não são Múltiplos");
                }
            }
            else
            {
                if (num2 % num1 == 0)
                { 
                    Console.WriteLine("São Múltiplos"); 
                }
                else 
                { 
                    Console.WriteLine("Não são Múltiplos"); 
                }
            }
        }
    }
}
