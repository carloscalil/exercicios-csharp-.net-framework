using System;

/*
 * Faça uma calculadora que leia dois números inteiros e imprima a soma, subtração, multiplicação, divisão e o resto da divisão desses números.
 */

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa calculadora--");

            Console.Write("Digite um valor inteiro:");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro valor inteiro:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Soma: {n1 + n2}");
            Console.WriteLine($"Subtração: {n1 - n2}");
            Console.WriteLine($"Multiplicação: {n1 * n2}");
            Console.WriteLine($"Divisão: {(double) n1 / n2}");
            Console.WriteLine($"Resto: {n1 % n2}");

            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
