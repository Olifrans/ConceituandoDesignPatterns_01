using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceituandoDesignPatterns_01
{
    public class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, String imposto) 
        {
            if ("ICMS".Equals(imposto))
            {

            }
            double icms = orcamento.Valor * 0.1;
            Console.WriteLine(icms);

            double iss = orcamento.Valor * 0.06;
            Console.WriteLine(iss);
        }
    }
}
