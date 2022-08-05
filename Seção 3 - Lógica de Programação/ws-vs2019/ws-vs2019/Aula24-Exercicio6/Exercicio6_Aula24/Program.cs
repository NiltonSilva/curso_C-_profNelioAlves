using System;
using System.Globalization;

namespace Exercicio6_Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e mostre:
            // a) a área do triângulo retângulo que tem A por base e C por altura.
            // b) a área do círculo de raio C. (pi = 3.14159)
            // c) a área do trapézio que tem A e B por bases e C por altura.
            // d) a área do quadrado que tem lado B.
            // e) a área do retângulo que tem lados A e B.

            double ladoA, ladoB, ladoC, areaTriRet, areaCirc, areaTrap, areaQuad, AreaRet;

            // ENTRADA DOS DADOS
            Console.WriteLine("Informe os três valores (A, B e C): ");
            string[] vetor = Console.ReadLine().Split(' ');
            ladoA = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            ladoB = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            ladoC = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            // PROCESSAMENTO DOS DADOS
            areaTriRet = ladoA * ladoC / 2.0;
            areaCirc = 3.14159 * Math.Pow(ladoC, 2);
            areaTrap = (ladoA + ladoB) * ladoC / 2.0;
            areaQuad = Math.Pow(ladoB, 2);
            AreaRet = ladoA * ladoB;

            // SAÍDA DOS DADOS
            Console.WriteLine("TRIÂNGULO: " + areaTriRet.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: " + areaCirc.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + areaTrap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuad.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + AreaRet.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
