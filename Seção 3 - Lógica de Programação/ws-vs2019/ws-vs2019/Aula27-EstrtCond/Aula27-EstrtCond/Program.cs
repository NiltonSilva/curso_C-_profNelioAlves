using System;

namespace Aula27_EstrtCond
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESTRUTURA SIMPLES
            int x = 10;
            Console.WriteLine("Bom dia");
            if (x > 5)
            {
                Console.WriteLine("Boa tarde");
            }
            Console.WriteLine("Boa noite");

            // ESTRUTURA COMPOSTA
            Console.Write("Entre com um número inteiro: ");
            int x2 = int.Parse(Console.ReadLine());
            if (x2 % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }

            // ESTRUTURA ENCADEADA
            Console.Write("Informe a hora atual: ");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }

        }
    }
}
