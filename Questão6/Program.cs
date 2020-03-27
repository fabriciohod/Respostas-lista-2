using System;
using System.Collections.Generic;
using System.Linq;
namespace Questão6
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] lados = new int[3];
            int[] teste = new int[] { 5, 3, 4 };
            // for (int i = 0; i < lados.Length; i++)
            // {
            //     Console.Write ($"Digite o {i + 1}º lado: ");
            //     lados[i] = int.Parse (Console.ReadLine ());
            // }
            System.Console.WriteLine (TesteTrianguloIsoceles (lados));
        }

        // static string TesteTriangulo (int[] lados)
        // {
        //     if (TesteTrianguloIsoceles (lados)) return "Triangulo Isoceles";
        //     else if (TesteTrianguloEquilatero (lados)) return "Triangulo Equilatero";
        //     else if (TesteTrianguloEscaleno (lados)) return "Triangulo Escaleno";
        //     else return "Nao e um triangulo";
        // }

        static int TesteTrianguloIsoceles (int[] lados)
        {
            var test = lados.Distinct ().OrderBy (n => n == lados[n++]);
           return test.Count ();
        }
        static bool TesteTrianguloEquilatero (int[] lados)
        {
            List<int> teste = new List<int> ();
            foreach (var item in lados.Distinct ().OrderBy (n => n))
            {
                teste.Add (item);
            }
            return teste.Count == 3 ? true : false;
        }

        static bool TesteTrianguloEscaleno (int[] lados)
        {
            List<int> teste = new List<int> ();
            foreach (var item in lados.Distinct ().OrderBy (n => n))
            {
                teste.Add (item);
            }
            return teste.Count == 0 ? true : false;
        }
    }
}