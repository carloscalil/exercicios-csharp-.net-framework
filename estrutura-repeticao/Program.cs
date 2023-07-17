using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrutura_repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {                        
            var respostaUsuario = 1;

            #region "do while - break"

            //teste da condição acontece na saída do loop, ou seja, executa pelo menos 1x.

            /*
            do //DO1
            {
                Console.WriteLine("Passou no DO1");

                do //DO1.1
                {
                    Console.WriteLine("Passou no DO1.1");
                    Console.Write("Deseja votar novamente (1-sim 0-não)?");
                    respostaUsuario = int.Parse(Console.ReadLine());
                } while (respostaUsuario != 0 && respostaUsuario != 1);

                if (respostaUsuario == 0)
                    break;

            } while (true);
            */

            #endregion

            #region "do while"

            //teste da condição acontece na saída do loop, ou seja, executa pelo menos 1x.

            /*
            do //DO1
            {             
                Console.WriteLine("Passou no DO1");

                do //DO1.1
                {
                    Console.WriteLine("Passou no DO1.1");
                    Console.Write("Deseja votar novamente (1-sim 0-não)?");
                    respostaUsuario = int.Parse(Console.ReadLine());
                } while (respostaUsuario != 0 && respostaUsuario != 1);

            } while (respostaUsuario == 1);
            */

            #endregion

            #region "while"

            //teste da condição acontece na entrada do loop.

            /*
            while (respostaUsuario == 1)
            {  
                Console.Write("Deseja votar novamente (1-sim 0-não)?");
                respostaUsuario = int.Parse(Console.ReadLine());
                
            } 
            */

            #endregion

            #region "for básico - contador (delimitar numero de execuções)"
            /*
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }*/
            #endregion

            #region "for que não é básico"

            /*
            for (;respostaUsuario == 1;) 
            {
                Console.Write("Deseja votar novamente (1-sim 0-não)?");
                respostaUsuario = int.Parse(Console.ReadLine());
            }
            */
            #endregion

            #region "do while / while - contador"
            //Você determina o local da alteração da variável de controle mediante sua necessidade.

            int j = 0;

            Console.WriteLine("do/while");
            do
            {
                Console.WriteLine($"Valor de i antes da alteração:{ j}");
                j++;
                Console.WriteLine($"Valor de i depois da alteração:{ j}");
            } while (j < 3);


            Console.WriteLine("while");
            j = 0;
            while (j < 3)
            {
                Console.WriteLine($"Valor de i antes da alteração:{j}");
                j++;
                Console.WriteLine($"Valor de i depois da alteração:{j}");
            }
            #endregion

            #region "for realizado de forma incorreta a partir de um do/while"

            int produto = 0;
            do
            {
                produto++;
                Console.WriteLine(produto);
            } while (produto < 4);

            // transcrição do do while para for => :((((((((((((((((((((((((((((((((((((((((((((
            //CUIDADOS - Principalmente com a confiança... :)

            for (int produto1 = 0; produto1 < 4; produto1++)
            {
                //produto1++;
                Console.WriteLine(produto1);
            }

            #endregion

            #region "manipulando um conjunto de caracteres com estrutura de repetição"

            string frase = "ronery";
            Console.WriteLine(frase);

            //for
            var quantidadeCaracteresFrase = frase.Length;
            for (int i = 0; i < quantidadeCaracteresFrase; i++)
            {
                Console.WriteLine($"frase[{i}] => {frase[i]}");
            }

            //for each
            foreach (var item in frase) //var => tipo da variável definido em momento de compilação.
            {
                Console.WriteLine(item);
            }

            // poderia ser do while ou while? SIM.

            #endregion

            Console.WriteLine($"Valor de respostaUsuario = {respostaUsuario}");
            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
