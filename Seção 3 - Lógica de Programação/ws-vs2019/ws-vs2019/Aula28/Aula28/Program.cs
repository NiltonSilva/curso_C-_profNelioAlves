﻿using System;

namespace Aula28
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            double desconto;
            if (preco > 100.0) 
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
        }
    }
}
