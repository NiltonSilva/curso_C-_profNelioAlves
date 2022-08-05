using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = false;
            char letra = '\u00BD';
            sbyte x = 100;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;  // Sempre que usar variável tipo long colocar o 'L' após o número para indicar esse tipo.
            float n5 = 4.5f;
            double n6 = 4.5;
            string mamae = "Lucilene Silva";
            object obj1 = "José Ferreira";  // o tipo obj é um tipo genérico, pois todos os demais tipos são subclasses de obj. Assim sendo, ele recebe qualquer tipo de valor
            object obj2 = 4.5f;

            Console.WriteLine("isTrue: " + isTrue);
            Console.WriteLine("letra: " + letra);
            Console.WriteLine("Valor de X: " + x);
            Console.WriteLine("Valor de n1: " + n1);
            Console.WriteLine("Valor de n2: " + n2);
            Console.WriteLine("Valor de n3: " + n3);
            Console.WriteLine("Valor de n4: " + n4);
            Console.WriteLine("Valor de n5: " + n5 + " em float");
            Console.WriteLine("Valor de n6: " + n6 + " em double");
            Console.WriteLine("mamãe: " + mamae);
            Console.WriteLine("obj1: " + obj1);
            Console.WriteLine("obj2: " + obj2);

            int a1 = int.MinValue;
            Console.WriteLine("Valor mínimo de tipo int: " + a1);
            int a2 = int.MaxValue;
            Console.WriteLine("Valor máximo de tipo int: " + a2);
            sbyte b1 = sbyte.MinValue;
            Console.WriteLine("Valor mínimo de tipo sbyte: " + b1);
            sbyte b2 = sbyte.MaxValue;
            Console.WriteLine("Valor máximmo de tipo sbyte: " + b2);
            decimal c1 = decimal.MinValue;
            Console.WriteLine("Valor mínimo do tipo decimal: " + c1);
            decimal c2 = decimal.MaxValue;
            Console.WriteLine("Valor máximo do tipo decimal: " + c2);
        }
    }
}
