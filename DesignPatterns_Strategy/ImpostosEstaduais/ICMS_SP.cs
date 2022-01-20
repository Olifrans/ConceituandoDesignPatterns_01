using DesignPatterns_Strategy.Interface;
using DesignPatterns_Strategy.Servicos;

namespace DesignPatterns_Strategy.ImpostosEstaduais
{
    public class ICMS_SP : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 18.00;
        }
    }
}