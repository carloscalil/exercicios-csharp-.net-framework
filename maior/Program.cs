using System;

/*
 * Faça um programa que leia 5 números inteiros informados pelo usuário e, no final, mostre o maior número e, também, a soma deles.
 */

namespace maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Maior / Soma--");

            #region "Solução sem Estrutura de Repetição"

            /*
            
            int maior = 0;

            Console.Write("Digite um valor inteiro:");
            int numero1 = int.Parse(Console.ReadLine());
            maior = numero1;

            Console.Write("Digite um valor inteiro:");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero2 > maior)
                maior = numero2;

            Console.Write("Digite um valor inteiro:");
            int numero3 = int.Parse(Console.ReadLine());
            if (numero3 > maior)
                maior = numero3;

            Console.Write("Digite um valor inteiro:");
            int numero4 = int.Parse(Console.ReadLine());
            if (numero4 > maior)
                maior = numero4;

            Console.Write("Digite um valor inteiro:");
            int numero5 = int.Parse(Console.ReadLine());
            if (numero5 > maior)
                maior = numero5;

            Console.WriteLine($"Soma:{numero1 + numero2 + numero3 + numero4 + numero5}");
            Console.WriteLine($"Maior:{maior}");
            */

            #endregion

            #region "Solução COM Estrutura de Repetição e ERRO do MAIOR 0 quando usuário informar somente números negativos"

            /*            
            int maior = 0;

            int soma = 0;
            int i = 0;

            do
            {
                Console.Write("Digite um valor inteiro:");
                int numero = int.Parse(Console.ReadLine());

                if (numero > maior)
                    maior = numero;

                soma += numero; //soma = soma + numero;

                i++;

            } while (i < 5);

            Console.WriteLine($"Soma:{soma}");
            Console.WriteLine($"Maior:{maior}");
            */

            #endregion
            #region "Solução COM Estrutura de Repetição 01"

            /*
            Console.Write("Digite um valor inteiro:");
            int maior = int.Parse(Console.ReadLine()); //1º número informado vai ser o MAIOR.

            int soma = maior;
            int i = 0;

            do
            {
                Console.Write("Digite um valor inteiro:");
                int numero = int.Parse(Console.ReadLine());

                if (numero > maior)
                    maior = numero;

                soma += numero; //soma = soma + numero;

                i++;

            } while (i < 4); //4x devido ao primeiro número ser solicitado antes do loop.

            Console.WriteLine($"Soma:{soma}");
            Console.WriteLine($"Maior:{maior}");
            */

            #endregion

            #region "Solução COM Estrutura de Repetição 02, 03, 04 ... "

            const int qtdeNumeros = 5;

            //int maior = -2147483648;
            int maior = int.MinValue;

            int soma = 0;
            int i = 0;

            do
            {
                Console.Write("Digite um valor inteiro:");
                int numero = int.Parse(Console.ReadLine());

                if (numero > maior)
                    maior = numero;

                //if (i > 0)
                //{
                //    if (numero > maior)
                //        maior = numero;
                //}
                //else
                //    maior = numero;

                //if (i == 0)
                //    maior = numero;
                //else
                //{
                //    if (numero > maior)
                //        maior = numero;
                //}

                //if (i == 0 || numero > maior) 
                //    maior = numero;

                //if (numero > maior || i == 0) 
                //    maior = numero;

                //if (i > 0 && numero > maior) CUIDADO - SOLUÇÃO INCORRETA !!!!!!!!!!!!!!!!!
                //    maior = numero;
                //else
                //    maior = numero;

                soma += numero; //soma = soma + numero;

                i++;

            } while (i < qtdeNumeros);

            Console.WriteLine($"Soma:{soma}");
            Console.WriteLine($"Maior:{maior}");

            #endregion

            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
