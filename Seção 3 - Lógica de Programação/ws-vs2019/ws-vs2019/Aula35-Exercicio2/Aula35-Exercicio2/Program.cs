using System;

namespace Aula35_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            // Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            // essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            // DECLARAÇÃO DAS VARIÁVEIS
            int contadorDentro = 0;
            int contadorFora = 0;

            // ENTRADA E PROCESSAMENTO DOS DADOS
            Console.Write("Informe a quantidade de números a serem lidos: ");
            int qdtNumerosLidos = int.Parse(Console.ReadLine());

            int[] vetor = new int[qdtNumerosLidos];

            for (int i = 0; i < qdtNumerosLidos; i++) 
            {
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] >= 10 && vetor[i] <= 20)
                {
                    contadorDentro++;
                }
                else 
                {
                    contadorFora++;
                }
            }

            // SAÍDA DOS DADOS
            Console.WriteLine($"{contadorDentro} in");
            Console.WriteLine($"{contadorFora} out");
        }
    }
}
