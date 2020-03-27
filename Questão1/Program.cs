using System;

namespace Questão1
{
    class Program
    {
        static void Main (string[] args)
        {
            (int numCarros, int totalVendido, int salarioFixo, int valorPorCarro) vendedor;
            Console.Write ("Digite a quantidade de carros vendidos: ");
            vendedor.numCarros = int.Parse (Console.ReadLine ());

            Console.Write ("Digite o seu salario: ");
            vendedor.salarioFixo = int.Parse (Console.ReadLine ());

            Console.Write ("Digite o valor total das vendas: ");
            vendedor.totalVendido = int.Parse (Console.ReadLine ());

            Console.Write ("Digite o valor adicional por carro: ");
            vendedor.valorPorCarro = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ($"O valor total e {CalculoTotalAReceber(vendedor) :c}");
        }
        static float CalculoTotalAReceber ((int numCarros, int totalVendido, int salarioFixo, int valorPorCarro) vendedor)
        {
            var sem5p = (vendedor.salarioFixo + (vendedor.totalVendido * (vendedor.valorPorCarro * vendedor.numCarros)));
            return sem5p + (sem5p * 0.5f);
        }
    }
}