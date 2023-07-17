using System;

/*
Faça um programa que receba um golpe que um personagem deve executar. O programa
deve ficar solicitando golpes até o usuário responder que não deseja mais executá-lo. Para
identificar os golpes, utilize 3 teclas: c (chute), s (soco) e m (magia), onde: chute vale 2
pontos, soco 4 pontos e magia 10 pontos. No final, o programa deve exibir para o usuário o
número e a pontuação obtida por cada tipo de golpe, bem como a pontuação total do
usuário.
 */

namespace jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa JOGO--");

            const int pontosPorChute = 2;
            const int pontosPorSoco = 4;
            const int pontosPorMagia = 10;

            int desejaContinuar = 0;

            int qtdeChutes = 0;
            int qtdeSocos = 0;
            int qtdeMagias = 0;

            do
            {
                Console.Write("Informe um golpe c (chute) s (soco) m (magia):");
                string golpe = Console.ReadLine().ToLower();

                switch (golpe)
                {
                    case "c":
                        qtdeChutes++;
                        break;
                    case "s":
                        qtdeSocos++;
                        break;
                    case "m":
                        qtdeMagias++;
                        break;
                    default:
                        Console.WriteLine("Golpe inválido.");
                        break;
                }

                Console.Write("Deseja informar outro golpe (0) não (1) sim?");
                desejaContinuar = int.Parse(Console.ReadLine());

            } while (desejaContinuar == 1);

            int totalDePontosPorChute = qtdeChutes * pontosPorChute;
            int totalDePontosPorSoco = qtdeSocos * pontosPorSoco;
            int totalDePontosPorMagia = qtdeMagias * pontosPorMagia;

            Console.WriteLine($"Qtde chutes: {qtdeChutes} - Pontos: {totalDePontosPorChute}.");
            Console.WriteLine($"Qtde socos: {qtdeSocos} - Pontos: {totalDePontosPorSoco}.");
            Console.WriteLine($"Qtde magias: {qtdeMagias} - Pontos: {totalDePontosPorMagia}.");
            Console.WriteLine($"Total de pontos: {totalDePontosPorChute + totalDePontosPorSoco + totalDePontosPorMagia}.");

            Console.ReadLine();
        }
    }
}
