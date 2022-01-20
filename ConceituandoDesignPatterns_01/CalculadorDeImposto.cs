using System;

namespace ConceituandoDesignPatterns_01
{
    public class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento)
        {
            double icms = new ICMS().CalculoICMS(orcamento);
            Console.WriteLine(icms);
        }


        public void RealizaCalculoISS(Orcamento orcamento)
        {
            double iss = new ISS().CalculoISS(orcamento);
            Console.WriteLine(iss);
        }
    }
}