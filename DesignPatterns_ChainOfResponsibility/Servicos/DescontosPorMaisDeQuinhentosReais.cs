using DesignPatterns_ChainOfResponsibility.Interface;
using DesignPatterns_ChainOfResponsibility.Servicos;

namespace DesignPatterns_Strategy.Servicos
{
    public class DescontosPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }             
            return  Proximo.Desconta(orcamento);     
        }       
    }
}