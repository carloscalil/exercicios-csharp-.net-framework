using System;

/*
 Faça um programa para ler três notas e o número de faltas de um aluno e escrever qual a sua situação final: Aprovado, Reprovado por Falta ou Reprovado por Média. A média para aprovação é 7,0 e o limite de faltas é 25% do total de aulas. O número de aulas ministradas no semestre foi de 80. A reprovação por falta sobrepõe a reprovação por Média.
 */

namespace escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteFaltas = 21;
            const double limiteMedia = 7;

            Console.WriteLine("--Bem vindo ao programa de média--");

            Console.Write("Número de faltas:");
            int faltas = int.Parse(Console.ReadLine());


            if (faltas < limiteFaltas)
            {
                Console.Write("Primeira nota:");
                double n1 = double.Parse(Console.ReadLine());
                Console.Write("Segunda nota:");
                double n2 = double.Parse(Console.ReadLine());
                Console.Write("Terceira nota:");
                double n3 = double.Parse(Console.ReadLine());
                double media = (n1 + n2 + n3) / 3;
                if (media >= limiteMedia)
                    Console.WriteLine("Aprovado.");
                else
                    Console.WriteLine("Reprovado por nota.");
            }
            else
                Console.WriteLine("Reprovado por faltas");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
