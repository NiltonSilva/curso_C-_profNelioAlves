using System;
using System.Globalization;

namespace Exercicio4_Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
            Console.Write("Informe o número do funcionário: ");
            int numeroFuncionario = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de horas trabalhadas: ");
            int numeroHorasTrabalhadas = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor da hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = valorHora * numeroHorasTrabalhadas;

            Console.WriteLine($"NUMBER = U$ {numeroFuncionario}");
            // Console.WriteLine($"SALARY = U$ {salary:f2}");
            Console.WriteLine("SALARY = U$ " + salary.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
