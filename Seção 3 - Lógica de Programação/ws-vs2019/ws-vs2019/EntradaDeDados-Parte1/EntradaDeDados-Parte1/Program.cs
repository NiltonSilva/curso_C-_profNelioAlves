using System;

namespace EntradaDeDados_Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma saudação");
            string frase = Console.ReadLine();  // Captura a palavra até que seja apertado ENTER.
            Console.WriteLine("Sua saudação foi: " + frase);

            Console.WriteLine();

            Console.WriteLine("Digite a primeira cor: ");
            string x = Console.ReadLine();
            Console.WriteLine("Digite a segunda cor: ");
            string y = Console.ReadLine();
            Console.WriteLine("Digite a terceira cor: ");
            string z = Console.ReadLine();

            Console.WriteLine($"Sua primeira cor foi {x}, \na segunda for foi {y} \ne a terceira cor foi {z}");

            Console.WriteLine();

            Console.WriteLine("Digite três frutas ou legumes: ");
            string frutaOuLegume = Console.ReadLine();

            string[] vetor = frutaOuLegume.Split(' ');

            // strig[] vetor = Console.ReadLine().Split(' ');   => é a mesma coisa das duas linhas de cima
            string p1 = vetor[0];
            string p2 = vetor[1];
            string p3 = vetor[2];
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}
