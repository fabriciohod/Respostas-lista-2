using System;

namespace Questão7
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write ("Digite sua iade: ");
            int idade = int.Parse (Console.ReadLine ());
            Console.WriteLine (ClassificarAtleta (idade));
        }
        static string ClassificarAtleta (int idade)
        {
            if (idade <= 5 && idade >= 10) return "Voce podera jogar na categoria Infantil";
            else if (idade >= 11 && idade <= 15) return "Voce podera jogar na categoria Juvenil";
            else if (idade >= 16 && idade <= 20) return "Voce podera jogar na categoria Junior";
            else return "Voce podera jogar na categoria Profissional";
        }
    }
}