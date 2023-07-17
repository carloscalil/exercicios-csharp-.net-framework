using System;
/*
 * 
Faça um programa que solicite a idade de várias pessoas e mostre:
• Total de pessoas com menos de 21 anos.
• Total de pessoas com mais de 50 anos.
• A média de idade das pessoas.
Importante: O programa termina quando a idade informada for -1 (Menos 1)
 */

namespace idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa IDADE--");

            #region "do while - break"

            const int idade21 = 21;
            int contadorPessoasMenor21anos = 0;

            const int idade50 = 50;
            int contadorPessoasMaior50anos = 0;

            int contadorPessoas = 0;

            int somaIdades = 0;

            do
            {   
                Console.Write("Digite a idade:");
                int idade = int.Parse(Console.ReadLine());

                if (idade == -1)
                    break;
                else if (idade < -1)
                {
                    Console.WriteLine("Informe uma idade positiva por favor.");
                    continue;
                }

                //TODO: Lógica aqui!
                somaIdades += idade;

                if (idade < idade21)
                    contadorPessoasMenor21anos++;
                else if (idade > idade50)
                    contadorPessoasMaior50anos++;

                contadorPessoas++; //contando apenas pessoas com idades diferentes de -1 e positivas.

            } while (true);

            Console.WriteLine($"Pessoas com menos de 21 anos:{contadorPessoasMenor21anos}");
            Console.WriteLine($"Pessoas com mais de 50 anos:{contadorPessoasMaior50anos}");
            Console.WriteLine($"Média de idade:{(double)somaIdades / (contadorPessoas != 0 ? contadorPessoas : 1)}"); //operador ternário.

            #endregion

            /* Alterar os laços abaixo para não contabilizar idades negativas*/

            #region "do while - continue"

            /*
            int idade = 0;

            do
            {
                Console.Write("Digite a idade:");
                idade = int.Parse(Console.ReadLine());

                if (idade == -1)
                    continue;

                //TODO: Lógica aqui.

            } while (idade != -1);
            */

            #endregion

            #region "while"

            /*
            Console.Write("Digite a idade:");
            int idade = int.Parse(Console.ReadLine());

            while (idade != -1)
            {
                //TODO: Lógica aqui.

                Console.Write("Digite a idade:");
                idade = int.Parse(Console.ReadLine());
            }            
            */

            #endregion

            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
