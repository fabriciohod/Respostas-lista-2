using System;

namespace Questão8
{
    class Program
    {
        static void Main (string[] args)
        {
            (int numero, int expoente) exp;
            Console.Write ("Digite um numero: ");
            exp.numero = int.Parse (Console.ReadLine ());
            Console.Write ("Digite o expoente");
            exp.expoente = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ($"Resultado: {PotenciacaoOP(exp)}");
        }

        static int PotenciacaoOP ((int numero, int expoente) exp)
        {
            int n = 1;
            for (int i = 1; i <= exp.expoente; i++)
            {
                n *= exp.numero;
            }
            return n;
        }
    }
}