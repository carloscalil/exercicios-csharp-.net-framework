using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro:"); //Escreve na tela a frase entre as aspas. Console => Terninal Write => escreve na tela e não pula linha
            int n1 = int.Parse(Console.ReadLine()); //leitura do valor informado pelo usuário, conversão do valor de string para inteiro e aramzenamento do valor inteiro na variável n1.
            Console.Write("Digite outro valor inteiro:");            
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma de {n1} com {n2} é: {n1 + n2}"); //interpolação - template string
            //Realiza a soma (operação aritmética da adição) devido a prioridade () de n1 com n2 e depois concatena (junta) o valor resultante com a string "A soma é"
          
            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
