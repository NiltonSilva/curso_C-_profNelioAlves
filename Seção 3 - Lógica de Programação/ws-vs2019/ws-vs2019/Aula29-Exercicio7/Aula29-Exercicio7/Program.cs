using System;
using System.Globalization;

namespace Aula29_Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas
            // de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            // ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            // Se o ponto estiver na origem, escreva a mensagem “Origem”.
            // Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            // situação.

            double coordenadaX, coordenadaY;

            Console.Write("Informe dois números: ");
            string[] vetor = Console.ReadLine().Split(' ');
            coordenadaX = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            coordenadaY = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            if (coordenadaX > 0 && coordenadaY > 0)
            {
                Console.WriteLine("Quadrante 1");
            }
            else if (coordenadaX != 0 && coordenadaY == 0)
            {
                Console.WriteLine("O ponto está sobre o eixo X");
            }
            else if (coordenadaX > 0 && coordenadaY < 0)
            {
                Console.WriteLine("Quadrante 2");
            }
            else if (coordenadaX < 0 && coordenadaY > 0)
            {
                Console.WriteLine("Quadrante 3");
            }
            else if (coordenadaX == 00 && coordenadaY != 0)
            {
                Console.WriteLine("O ponto está sobre o eixo Y");
            }
            else if (coordenadaX < 0 && coordenadaY < 0)
            {
                Console.WriteLine("Quadrante 4");
            }
            else 
            {
                Console.WriteLine("O ponto está sobre a origem.");
            }
        }
    }
}
