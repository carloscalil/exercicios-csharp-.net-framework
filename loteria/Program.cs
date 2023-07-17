using System;

/*
 * Três amigos jogaram na loteria. Caso eles ganhem, o prêmio deve ser repartido proporcionalmente ao valor que cada um deu para a realização da aposta. Faça um programa que leia quanto cada apostador investiu, o valor do prêmio, e imprima quanto cada um ganharia do prêmio com base no valor investido.
 */

namespace loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa LOTERIA--");

            #region "Entrada"

            Console.WriteLine("Informe o valor apostado por cada amigo:");
            Console.Write("Amigo1:");
            double valorApostaAmigo1 = double.Parse(Console.ReadLine());
            Console.Write("Amigo2:");
            double valorApostaAmigo2 = double.Parse(Console.ReadLine());
            Console.Write("Amigo3:");
            double valorApostaAmigo3 = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor do prêmio:");
            double valorPremio = double.Parse(Console.ReadLine());

            #endregion

            #region "Processamento"

            double valorTotalApostado = valorApostaAmigo1 + valorApostaAmigo2 + valorApostaAmigo3;

            double valorPremioAmigo1 = valorApostaAmigo1 / valorTotalApostado * valorPremio;
            double valorPremioAmigo2 = valorApostaAmigo2 / valorTotalApostado * valorPremio;
            double valorPremioAmigo3 = valorApostaAmigo3 / valorTotalApostado * valorPremio;

            #endregion

            #region "Saída"
            Console.WriteLine("Os valores dos prêmios serão:");
            Console.WriteLine($"Amigo1:{valorPremioAmigo1:F2}");
            Console.WriteLine($"Amigo2:{valorPremioAmigo2:0.00}");
            Console.WriteLine($"Amigo3:{valorPremioAmigo3:F2}");

            /*
            Console.WriteLine("Os valores dos prêmios serão:");
            Console.WriteLine($"Amigo1:{valorApostaAmigo1 / valorTotalApostado * valorPremio:F2}");
            Console.WriteLine($"Amigo2:{valorApostaAmigo2 / valorTotalApostado * valorPremio:0.00}");
            Console.WriteLine($"Amigo3:{valorApostaAmigo3 / valorTotalApostado * valorPremio:F2}");
            */
            #endregion

            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
