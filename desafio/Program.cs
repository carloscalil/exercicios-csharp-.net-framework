using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, z = 0;
            Console.WriteLine(n++ + ++n * 2);
            //n = 2 + n++ + ++n * 2;
            //Console.WriteLine(n);

            Console.WriteLine(++z * 2);
            //Console.WriteLine(2 + n++ + 2);
            //Console.WriteLine(n);

            //z = 1 + n++; //pós-incremento => somar <depois>
            // z = 1 + n
            // n = n + 1
            //n++ => n += 1 => n = n + 1



            //Console.WriteLine($"Valor de z = {z++}");
            //Console.WriteLine($"Valor de z = {z}");
            //z = z + 1

            //n = 0;

            //z = 1 + ++n; // pré-incremento => somar <antes>
            //n = n + 1
            //z = 1 + n

            //++n => n += 1 => n = n + 1

            //Console.WriteLine($"Valor de z = {++z}");
            //z = z + 1
            //Console.WriteLine($"Valor de z = {z}");


            Console.ReadLine();
        }
    }
}
