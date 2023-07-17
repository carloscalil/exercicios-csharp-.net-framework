using System;

/*
 * Em uma eleição presidencial, existem quatro candidatos. Os votos são informados através de códigos.
Os códigos utilizados são:
• 1,2,3,4 votos para os respectivos candidatos;
• 5 voto nulo;
• 6 voto em branco.

Assim, escreva um programa para receber um único voto e imprima:
• Se o usuário votou em um candidato: "Voto contabilizado com sucesso..."
• Se o usuário votou nulo: "Voto nulo contabilizado..."
• Se o usuário votou em branco: "Voto branco contabilizado...

Até aqui valem as soluções de 1 a 7

Daqui em diante elas não atendem o requisito.

@ Caso o usuário informe um código diferente, escreva: "Voto inválido!"

*/

namespace eleicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ELEIÇÃO--");

            Console.Write("Digite um voto:");
            var voto = int.Parse(Console.ReadLine());

            #region "Solução 1"
            //Primeira solução com Estruturas de Decisões simples
            //PONTO: Performance => sempre testa todas as condições
            /*
            if (voto == 1)
                Console.WriteLine("Voto contabilizado com sucesso...");

            if (voto == 2)
                Console.WriteLine("Voto contabilizado com sucesso...");

            if (voto == 3)
                Console.WriteLine("Voto contabilizado com sucesso...");

            if (voto == 4)
                Console.WriteLine("Voto contabilizado com sucesso...");

            if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");

            if (voto == 6)
                Console.WriteLine("Voto branco contabilizado...");
            */
            #endregion

            #region "Solução 2"
            //Segunda solução com Estrutura de Decisão Encadeada
            //PONTO: Achou a condição VERDADEIRA, para de testar as demais (abonda a Estrutura de Decisão)
            /*
            if (voto == 1)
                Console.WriteLine("Voto contabilizado com sucesso...");

            else if (voto == 2)
                Console.WriteLine("Voto contabilizado com sucesso...");

            else if (voto == 3)
                Console.WriteLine("Voto contabilizado com sucesso...");

            else if (voto == 4)
                Console.WriteLine("Voto contabilizado com sucesso...");

            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");

            else if (voto == 6)
                Console.WriteLine("Voto branco contabilizado...");
            */
            #endregion

            #region "Solução 3"
            //Terceira solução com Estrutura de Decisão Encadeada
            //MARINA

            //SUGESTÃO: Procurem saber quais condições acontencem em um maior número de vezes
            //          e iniciem a estrutura de decisão com essas condições.  

            /*
            if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto == 6)
                Console.WriteLine("Voto branco contabilizado...");
            else
                Console.WriteLine("Voto contabilizado com sucesso...");
            */
            #endregion

            #region "Solução 4"
            //Quarta solução com Estrutura de Decisão Encadeada
            //Aleph

            /*
            if (voto <= 4)
                Console.WriteLine("Voto contabilizado com sucesso..."); 
            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto == 6)
                Console.WriteLine("Voto branco contabilizado...");
            */

            #endregion

            #region "Solução 5"
            //Quinta solução com Estrutura de Decisão Encadeada
            //Nathan - retirando o último else if

            /*
            if (voto <= 4)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");
            else
                Console.WriteLine("Voto branco contabilizado...");
            */
            #endregion

            #region "Solução 6"
            //Sexta solução com Estrutura de Decisão Encadeada
            //Aleph -> Alterar o limite da primeira condição

            /*
            if (voto < 5)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");
            else
                Console.WriteLine("Voto branco contabilizado...");
            */

            #endregion

            #region "Solução 7 switch case"
            //Sétima solução com Switch Case
            //Ronery

            //sugestão: estudar case when

            /*
            switch (voto)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Voto contabilizado com sucesso...");
                    break;
                case 5:
                    Console.WriteLine("Voto nulo contabilizado...");
                    break;
                case 6:
                    Console.WriteLine("Voto branco contabilizado...");
                    break;
                //default:
                //  Console.WriteLine("Voto branco contabilizado...");
                //  break;
                
            }
            */

            #endregion

            #region "Solução 8"
            //Oitava solução com Estrutura de Decisão Encadeada já contemplando voto inválido

            /*
            if (voto < 1)
                Console.WriteLine("Voto inválido!");
            else if (voto < 5)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto == 6)
                Console.WriteLine("Voto branco contabilizado...");
            else 
                Console.WriteLine("Voto inválido!");
            */

            #endregion

            #region "Solução 9"
            //Nona solução com Estrutura de Decisão Encadeada já contemplando voto inválido

            /*
            if (voto < 5)
                if (voto < 1)
                    Console.WriteLine("Voto inválido!");
                else
                    Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto == 6)
                Console.WriteLine("Voto branco contabilizado...");
            else
                Console.WriteLine("Voto inválido!");
            */

            #endregion

            #region "Solução 10"
            //Décima solução com Estrutura de Decisão Encadeada e utilização de operadores lógicos já contemplando voto inválido

            /*
            if (voto == 1 || voto == 2 || voto == 3 || voto == 4)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto == 6)
                Console.WriteLine("Voto branco contabilizado...");
            else
                Console.WriteLine("Voto inválido!");
            */

            #endregion

            #region "Solução 11"
            //Décima primeira solução com Estrutura de Decisão Encadeada e utilização de operadores lógicos já contemplando voto inválido

            /*
            if (voto > 0 && voto < 5)                
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto == 6)
                Console.WriteLine("Voto branco contabilizado...");
            else
                Console.WriteLine("Voto inválido!");
            */

            #endregion

            #region "Solução 12 switch case"
            //Sétima solução com Switch Case
            
            //sugestão: estudar case when

            switch (voto)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Voto contabilizado com sucesso...");
                    break;
                case 5:
                    Console.WriteLine("Voto nulo contabilizado...");
                    break;
                case 6:
                    Console.WriteLine("Voto branco contabilizado...");
                    break;
                default:
                    Console.WriteLine("Voto inválido...");
                    break;                
            }

            #endregion

            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
