using DesignPatterns_Strategy.Interface;
using DesignPatterns_Strategy.Servicos;

namespace DesignPatterns_Strategy.ImpostosFederais
{
    public class IPI : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 10.00;
        }
    }
}