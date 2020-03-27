using System;

namespace Questão5
{
    class Program
    {
        static void Main (string[] args)
        {
            (float n1, float n2) notas;
            Console.Write ("Digite a primeira nota: ");
            notas.n1 = float.Parse (Console.ReadLine ());

            Console.Write ("Digite a segunda nota: ");
            notas.n2 = float.Parse (Console.ReadLine ());

            Console.WriteLine ($"{TesteDeAprovacao (notas) :n}");
        }
        static string TesteDeAprovacao ((float n1, float n2) notas) =>
            ((notas.n1 + notas.n2) / 2) >= 5.0f ?
            $"Voce foi APROVADO sua media e {(notas.n1 + notas.n2)/2}" :
            $"Voce foi REPROVADO sua media e {(notas.n1 + notas.n2)/2}";
    }
}