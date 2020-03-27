using System;

namespace Questão2
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write ("Dgita uma temperatura em graus Celsius: ");
            float temperatura = float.Parse (Console.ReadLine ());
            Console.WriteLine ($"Sua temperatura em Fahrenheit e {ConvercaoDeTemperatura(temperatura)} °F");
        }
        static float ConvercaoDeTemperatura (float celsius) => (9 * celsius + 160) / 5;
    }
}