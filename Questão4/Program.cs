using System;
using System.Linq;

namespace Questão4
{
    class Program
    {
        static void Main (string[] args)
        {
            float[] numeros = new float[3];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write ($"\nDigite o {i + 1}º numero: ");
                numeros[i] = float.Parse (Console.ReadLine ());
            }
            Console.WriteLine ($"Soma dos dois maiores nomeros: {SomaDosMaioresValores(numeros)}");
        }
        static float SomaDosMaioresValores (float[] numeros)
        {
            float maior = 0;
            foreach (var item in numeros.Where (n => n > numeros.Min ()))
            {
                maior += item;
            }
            return maior;
        }
    }
}