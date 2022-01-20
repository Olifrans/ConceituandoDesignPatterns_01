using DesignPatterns_ChainOfResponsibility.Interface;
using DesignPatterns_ChainOfResponsibility.Servicos;

namespace DesignPatterns_Strategy.Servicos
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontosPorCincoItens();
            IDesconto d2 = new DescontosPorMaisDeQuinhentosReais();
            IDesconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconta(orcamento);
        }
    }
}