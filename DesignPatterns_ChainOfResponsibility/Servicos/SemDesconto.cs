using DesignPatterns_ChainOfResponsibility.Interface;
using DesignPatterns_ChainOfResponsibility.Servicos;

namespace DesignPatterns_Strategy.Servicos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}