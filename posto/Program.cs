using System;

/*
Analise a seguinte informação:

Em um jogo, existe um posto que está vendendo combustíveis com a seguinte tabela de descontos:

Álcool
até 20 litros (inclusive 20 litros), desconto de 2% por litro
acima de 20 litros, desconto de 5% por litro

Gasolina
até 20 litros (inclusive 20 litros), desconto de 3% por litro
acima de 20 litros, desconto de 6% por litro

Após à análise, faça um programa que leia o número de litros vendidos e o tipo de combustível (codificado da seguinte forma: 1-álcool, 2-gasolina), calcule e imprima o valor
a ser pago pelo jogador, sabendo-se que o preço do litro da gasolina é R$ 5.00 e o preço do litro do álcool é R$ 3.50
 */

namespace posto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa POSTO--");

            const double valorLitroAlcool = 3.5;
            const double valorLitroGasolina = 5;
            const double valorDescontoLitroAlcoolAte20Litros = 0.02;
            const double valorDescontoLitroAlcoolAcima20Litros = 0.05;
            const double valorDescontoLitroGasolinaAte20Litros = 0.03;
            const double valorDescontoLitroGasolinaAcima20Litros = 0.06;
            const double limiteLitrosCombustivelParaDesconto = 20;

            bool conseguiuConverter = false;

            int tipoCombustivel = 0;

            do
            {
                Console.Write("Tipo de combustível 1 (álcool) 2 (gasolina):");
                conseguiuConverter = int.TryParse(Console.ReadLine(), out tipoCombustivel);

            } while (!conseguiuConverter || (tipoCombustivel != 1 && tipoCombustivel != 2));


            double litros = 0;

            do
            {
                Console.Write("Litros:");
                conseguiuConverter = double.TryParse(Console.ReadLine(), out litros);

            } while (!conseguiuConverter || litros < 0);

            //TODO Lógica!
            
            double valorDescontoAlcool = 1 - ((litros <= limiteLitrosCombustivelParaDesconto) ? valorDescontoLitroAlcoolAte20Litros : valorDescontoLitroAlcoolAcima20Litros);

            double valorDescontoGasolina = 1 - ((litros <= limiteLitrosCombustivelParaDesconto) ? valorDescontoLitroGasolinaAte20Litros : valorDescontoLitroGasolinaAcima20Litros);

            double valorLitro = (tipoCombustivel == 1) ? valorLitroAlcool * valorDescontoAlcool : valorLitroGasolina * valorDescontoGasolina;
            
            double valorTotalAPagar = valorLitro * litros;

            Console.WriteLine($"Valor total a pagar:{valorTotalAPagar:0.00}");

            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
