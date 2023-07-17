using System;

/*
 * Um pescador comprou um microcomputador para controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo (50 quilos) deve pagar uma multa de R$ 4,00 por quilo excedente. Assim, faça um
programa que leia o peso de peixes e verifique se há excesso. Se houver, o programa também deve calcular o valor da multa que o pescador deverá pagar. No final, o programa deve imprimir o excesso e a multa paga pelo pescador.
 */

namespace pescador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pesoLimiteKg = 50;
            const double multaPorKg = 4;
            
            Console.WriteLine("--Bem vindo ao programa PESCADOR--");

            Console.Write("Informe o peso pescado em Kg:");
            double pesoKg = double.Parse(Console.ReadLine());

            double excessoKg = 0;

            if (pesoKg > pesoLimiteKg)
                excessoKg = pesoKg - pesoLimiteKg;                

            Console.WriteLine($"Excesso:{excessoKg:0.00}");
            Console.WriteLine($"Multa:{excessoKg * multaPorKg:0.00}");

            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
