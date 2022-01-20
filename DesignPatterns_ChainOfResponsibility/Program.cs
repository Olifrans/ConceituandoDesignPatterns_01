using DesignPatterns_ChainOfResponsibility.ImpostosEstaduais;
using DesignPatterns_ChainOfResponsibility.ImpostosFederais;
using DesignPatterns_ChainOfResponsibility.ImpostosMunicipais;
using DesignPatterns_ChainOfResponsibility.Interface;
using DesignPatterns_ChainOfResponsibility.Servicos;
using System;



using System;

namespace DesignPatterns_ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //municipais
            IImposto iss_sp = new ISS_SP();


            //Estaduais
            IImposto icms_sp = new ICMS_SP();
            IImposto icms_mg = new ICMS_MG();

            //Federais
            IImposto pis = new PIS();
            IImposto cofins = new COFINS();
            IImposto ipi = new IPI();

            Orcamento orcamento = new Orcamento(500000.00);
            CalculadorDeImposto calcula = new CalculadorDeImposto();

            //municipais
            calcula.RealizaCalculo(orcamento, iss_sp);

            //Estaduais
            calcula.RealizaCalculo(orcamento, icms_sp);
            calcula.RealizaCalculo(orcamento, icms_mg);

            //Federais
            calcula.RealizaCalculo(orcamento, pis);
            calcula.RealizaCalculo(orcamento, cofins);
            calcula.RealizaCalculo(orcamento, ipi);

            Console.ReadKey();
        }
    }
}
