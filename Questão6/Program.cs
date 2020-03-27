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
            for (int i = 0; i < lados.Length; i++)
            {
                Console.Write ($"Digite o {i + 1}º lado: ");
                lados[i] = int.Parse (Console.ReadLine ());
            }
            System.Console.WriteLine (TesteTriangulo (lados));
        }

        static string TesteTriangulo (int[] lados)
        {
            if (TesteTrianguloIsoceles (lados)) return "Triangulo Isoceles";
            else if (TesteTrianguloEquilatero (lados)) return "Triangulo Equilatero";
            else if (TesteTrianguloEscaleno (lados)) return "Triangulo Escaleno";
            else return "Nao e um triangulo";
        }

        static bool TesteTrianguloIsoceles (int[] lados)
        {
            int ladoMax = 0;
            int ladoMin = 0;
            for (int i = 0; i < lados.Length; i++)
            {
                if (lados[i] == lados.Max ()) ladoMax++;
                if (lados[i] == lados.Min ()) ladoMin++;
            }
            return ladoMax == 2 || ladoMin == 2 ? true : false;
        }
        static bool TesteTrianguloEquilatero (int[] lados)
        {
            int qtdLados = 0;
            for (int i = 0; i < lados.Length; i++)
            {
                if (lados[i] == lados.Max ()) qtdLados++;
            }
            return qtdLados == 3 ? true : false;
        }

        static bool TesteTrianguloEscaleno (int[] lados)
        {
            foreach (var item in lados.Where (n => lados.Distinct ().Count () == 1))
            {
                return false;
            }
            return true;
        }
    }
}