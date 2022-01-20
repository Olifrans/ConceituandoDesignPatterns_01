using DesignPatterns_ChainOfResponsibility.Interface;
using DesignPatterns_ChainOfResponsibility.Servicos;

namespace DesignPatterns_ChainOfResponsibility.ImpostosFederais
{
    public class PIS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 1.65;
        }
    }
}