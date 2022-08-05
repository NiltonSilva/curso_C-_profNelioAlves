using System;
using System.Globalization; // para imprimir com ponto no lugar da virgula preciso dessa biblioteca.

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Atena";

            Console.Write("Boa tarde!");
            Console.WriteLine("Bom dia");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Genero: " + genero);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Saldo: " + saldo);
            Console.WriteLine("Saldo: " + saldo.ToString("f2"));
            Console.WriteLine("Saldo: " + saldo.ToString("f2",  CultureInfo.InvariantCulture)); //  para imprimir com o ponto no lugar da vírgula. Assim vai desconsiderar qualquer formatação específica de países
            Console.WriteLine("Saldo: " + saldo.ToString("f4"));
            Console.WriteLine("Saldo: " + saldo.ToString("f4", CultureInfo.InvariantCulture));  
            Console.WriteLine("nome:" + nome);
            Console.WriteLine("----------------- PLACE HOLDERS ------------------");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2} reais.", nome, idade, saldo);
            // nessa técnica, as variáveis são numeradas a partir do 0 e esses números eu coloco dentro de chaves. Em seguinda, após fechar as aspas, devo dizer quais são as variáveis que serãoo usadas.
            Console.WriteLine("----------------- INTERPOLAÇÃO ------------------");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:f2} reais.");
            Console.WriteLine("----------------- CONCATENAÇÃO ------------------");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("f2") + " reais.");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("f2", CultureInfo.InvariantCulture) + " reais.");
        }
    }
}
