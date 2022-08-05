using System;

namespace ConversaoImplicitaECasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversão implícita entre tipos é quando um conteúdo de um certo tipo pode naturalmente atribuido para uma variavel de outro tipo
            float x = 4.5f; // tem 4 bytes
            double y = x;   // tem 8 bytes. Logo, os 8 bytes do double podem comportar os 4 bytes do float.
            Console.WriteLine(y);

            double a = 5.1;
            // float b = a;    => Por padrão, isso não é possível, pois estou tentando passar um double (8 bytes) em um float (4 bytes). Pode acarretar em perda de informação.
            float b = (float)a;   // Essa é a forma que o compilador vai deixar eu fazer essa operação sem erros.

            double c;
            int d;

            c = 5.1;
            d = (int) c;
            Console.WriteLine(c);
            Console.WriteLine(d);   //  nesse caso o valor que antes erea 5.1 se tornará 5 (somente a parte inteira do valor, serão truncados).

            // Casting é a conversão explícita entre tipos COMPATÍVEIS
            int e = 5;
            int f = 2;
            double resultado = (double) e / f;  // Se eu dividir um número inteiro por outro o resultado será um numero interiro. Devo fazer o casting no primeiro número (transformar em double ou float) para que o resulto saia com seu valor decimal.
            Console.WriteLine("resultado: " + resultado);

            // Fórmula de bhaskara
            double _a = 1.0;
            double _b = -3.0;
            double _c = -4.0;
            double delta;
            double x1;
            double x2;

            delta = Math.Pow(_b, 2.0) - 4.0 * _a * _c;
            x1 = (-_b + Math.Sqrt(delta)) / (2.0 * _a);
            x2 = (-_b - Math.Sqrt(delta)) / (2.0 * _a);

            Console.WriteLine("valor de delta: " + delta);
            Console.WriteLine("valor de x1: " + x1);
            Console.WriteLine("Valor de x2: " + x2);
        }
    }
}
