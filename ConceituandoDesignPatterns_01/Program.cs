using System;

namespace ConceituandoDesignPatterns_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);
            CalculadorDeImposto calcula = new CalculadorDeImposto();

            calcula.RealizaCalculo(orcamento, iss);
            calcula.RealizaCalculo(orcamento, icms);

            Console.ReadKey();
            //Console.WriteLine("iss");
            //Console.WriteLine("icms");
        }
    }
}