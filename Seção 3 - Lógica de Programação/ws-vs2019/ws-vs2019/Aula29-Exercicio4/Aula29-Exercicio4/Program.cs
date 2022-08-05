using System;

namespace Aula29_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leia a hora inicial e a hora final de um jogo.A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            int startHour, finalHour, duration;

            Console.Write("Informa a hora de início da partida e a hora de término: ");
            string[] vetor = Console.ReadLine().Split(' ');
            startHour = int.Parse(vetor[0]);
            finalHour = int.Parse(vetor[1]);

            if (startHour < finalHour)
            {
                duration = finalHour - startHour;
            }
            else if (startHour == finalHour)
            {
                duration = 24;
            }
            else 
            {
                duration = (24 - startHour) + finalHour;
            }

            Console.WriteLine($"O JOGO DUROU {duration} HORAS(S).");
        }
    }
}
