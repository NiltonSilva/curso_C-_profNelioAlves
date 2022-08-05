using System;

namespace Aula33_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
            // cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            // menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).

            int coordX, coordY;
            bool flag = true;

            while (flag)
            {
                Console.Write("Coordenada X: ");
                coordX = int.Parse(Console.ReadLine());
                Console.Write("Coordenada Y: ");
                coordY = int.Parse(Console.ReadLine());
                if (coordX > 0 && coordY > 0)
                {
                    Console.WriteLine("primeiro quadrante");
                }
                else if (coordX < 0 && coordY > 0)
                {
                    Console.WriteLine("segundo quadrante");
                }
                else if (coordX < 0 && coordY < 0)
                {
                    Console.WriteLine("Terceiro quadrante");
                }
                else if (coordX > 0 && coordY < 0)
                {
                    Console.WriteLine("Quarto quadrante");
                }
                else {
                    flag = false;
                }
            }
        }
    }
}
