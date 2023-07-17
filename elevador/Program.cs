using System;

/*
 Faça um programa que mostre se um elevador pode entrar em funcionamento ou não.
 Primeiro, o programa deve solicitar o peso máximo, em Kg, suportado pelo elevador e o
 número de pessoas que desejam utilizá-lo. Depois, solicitar o peso de cada pessoa e, no
 final, exibir se o elevador poderá entrar em funcionamento ou não. Caso a soma dos pesos
 das pessoas for maior que o peso máximo suportado pelo elevador, ele não poderá entrar
 em funcionamento.
 */

namespace elevador
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--Bem vindo ao programa ELEVADOR--");

            bool conseguiuConverter = false;

            double pesoMaximo = 0;

            do
            {
                Console.Write("Digite o peso máximo suportado pelo elevador em Kg: ");
                conseguiuConverter = double.TryParse(Console.ReadLine(), out pesoMaximo);

            } while (!conseguiuConverter || pesoMaximo < 0);

            int totalPessoas = 0;

            do
            {
                Console.Write("Quantas pessoas irão utilizar o elevador? ");
                conseguiuConverter = int.TryParse(Console.ReadLine(), out totalPessoas);

            } while (!conseguiuConverter || totalPessoas < 0);

            double totalPesoPessoas = 0;
            double pesoPessoa = 0;

            for (int i = 1; i <= totalPessoas; i++)
            {
                do
                {
                    Console.Write($"Digite o peso da {i}ª pessoa em Kg:");
                    conseguiuConverter = double.TryParse(Console.ReadLine(), out pesoPessoa);

                } while (!conseguiuConverter || pesoPessoa <= 0);
                
                totalPesoPessoas += pesoPessoa;
            }

            Console.WriteLine($"Peso máximo suportado pelo elevador:{pesoMaximo}");
            Console.WriteLine($"Peso total das pessoas:{totalPesoPessoas}");
            Console.WriteLine("Então............");

            if (totalPesoPessoas <= pesoMaximo)
                Console.WriteLine("Elevador => Subindo.... ou Descendo...."); 
            else
                Console.WriteLine("Pesso máximo excedido. Elevador não pode entrar em funcionamento");

            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
