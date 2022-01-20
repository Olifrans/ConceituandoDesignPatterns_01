using DesignPatterns_Strategy.Interface;
using DesignPatterns_Strategy.Servicos;

namespace DesignPatterns_Strategy.ImpostosFederais
{
    public class COFINS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 7.60;
        }
    }
}