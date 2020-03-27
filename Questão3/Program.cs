using System;

namespace Questão3
{
    class Program
    {
        static void Main (string[] args)
        {
            (float litros, string tipo) compra;
            Console.Write ("Dgite quantos litros foram abstecidos: ");
            compra.litros = float.Parse (Console.ReadLine ());
            Console.Write ("Gasolina ou Alcool? : ");
            compra.tipo = Console.ReadLine ().ToLower ();
            System.Console.WriteLine ($"valor a pagar: {AplicarDesconto(compra.litros, compra.tipo) :c}");
        }

        static float AplicarDesconto (float litros, string tipo) =>
            (tipo) switch
            {
                "gasolina" => DescontoGasolina (litros),
                "alcool" => DescontoGasolina (litros),
                _ =>
                throw new ArgumentException ("Tipo de compustivel invalido ou erro na digitacao")
            };
        static float DescontoGasolina (float litros)
        {
            if (litros <= 20) return litros * 3.168f;
            else return litros * 3.102f;
        }
        static float DescontoAlcool (float litros)
        {
            if (litros <= 20) return litros * 2.813f;
            else return litros * 2.755f;
        }
    }
}