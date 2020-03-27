using System;

namespace Questão10
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write ("Digite a quantidade de dias: ");
            int dias = int.Parse (Console.ReadLine ());
            System.Console.WriteLine (AnosMesesDias (dias));
        }
        static string AnosMesesDias (int dias)
        {
            var _anos = dias / 365;
            var _meses = _anos / 30;
            var _dias = _meses / 30;
            return $"{_anos} ano(s), {_meses} mes(es), {_dias} dia(s)";
        }
    }
}