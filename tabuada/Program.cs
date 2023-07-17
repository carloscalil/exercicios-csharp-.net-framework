using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa TABUADA--");

            Console.Write("Digite um valor inteiro:");
            int numero = int.Parse(Console.ReadLine());

            //for
            Console.WriteLine("Tabuada com for");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{numero}x{i}={numero*i}");
            }

            int contador = 0;

            Console.WriteLine("Tabuada com while");
            //while            
            while (contador < 11)
            {                
                Console.WriteLine($"{numero}x{contador}={numero * contador}");
                contador++;
            }

            Console.WriteLine("Tabuada com do while");
            //while
            contador = 0;
            do
            {
                Console.WriteLine($"{numero}x{contador}={numero * contador}");
                contador++;
            } while (contador < 11);

            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
