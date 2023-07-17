using System;

/*
Faça um programa que receba uma senha e teste se ela é igual à 904087. Se a senha estiver correta escreva “Acesso permitido”, do contrário, escreva a mensagem “Você não tem acesso ao sistema.
 */

namespace senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string senhaCorreta = "904087";

            Console.WriteLine("--Bem vindo ao programa SENHA--");

            Console.Write("Digite uma senha:");
            string senha = Console.ReadLine();

            if (senha == senhaCorreta)
                Console.WriteLine("Acesso Permitido.");
            else
            {
                Console.WriteLine("Você não tem acesso ao sistema.");
                Console.WriteLine("Execute o programa novamente.");
            }

            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
