using System;

namespace Aula33_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            // um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            // 4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            // que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            // mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            // exemplo.

            bool flag = true;

            int contadorAlcool = 0;
            int contadorGasolina = 0;
            int contadorDiesel = 0;
            int opcao ;

            Console.Write("Digite 1-Alcool, 2-Gasolina, 3-Diesel: ");
            while (flag)
            {
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    contadorAlcool++;
                }
                else if (opcao == 2)
                {
                    contadorGasolina++;
                }
                else if (opcao == 3)
                {
                    contadorDiesel++;
                }
                else if (opcao == 4)
                {
                    flag = false;
                }
                else {
                    Console.Write("Informe um valor válido: ");
                }
            }
            Console.WriteLine($"MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {contadorAlcool}");
            Console.WriteLine($"Gasolina: {contadorGasolina}");
            Console.WriteLine($"Diesel: {contadorDiesel}");
        }
    }
}
