using System;

namespace ExercicioDeFixacaoAula23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome completo: ");
            string fullName = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa? ");
            int numberBadRooms = int.Parse(Console.ReadLine());

            Console.Write("Informe o preço do produto: ");
            double priceProduct = double.Parse(Console.ReadLine());

            Console.Write("Informe seu último nome, idade e altura: ");
            string[] fullNameAgeHeight = Console.ReadLine().Split(' ');

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            Console.WriteLine($"Nome completo: {fullName}.");
            Console.WriteLine($"Número de quartos: {numberBadRooms}.");
            Console.WriteLine($"Preço do produto: {priceProduct:f2}.");
            Console.WriteLine(fullNameAgeHeight[0]);
            Console.WriteLine(fullNameAgeHeight[1]);
            Console.WriteLine(fullNameAgeHeight[2]);
        }
    }
}
