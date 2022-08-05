using System;

namespace Aula33_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
            // incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            // impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.

            string senha = "2020";

            Console.Write("Senha: ");
            string novaSenha = Console.ReadLine();

            while (senha != novaSenha) {
                Console.WriteLine("Senha inválida!");

                Console.Write("Por favor, digite a senha novamente: ");
                novaSenha = Console.ReadLine();
            }

            if (senha == novaSenha) 
            {
                Console.WriteLine("Acesso Permitido!");
            }
        }
    }
}
