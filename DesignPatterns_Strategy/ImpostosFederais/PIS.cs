using DesignPatterns_Strategy.Interface;
using DesignPatterns_Strategy.Servicos;

namespace DesignPatterns_Strategy.ImpostosFederais
{
    public class PIS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 1.65;
        }
    }
}