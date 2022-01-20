using DesignPatterns_Strategy.Interface;
using DesignPatterns_Strategy.Servicos;

namespace DesignPatterns_Strategy.ImpostosEstaduais
{
    public class ICMS_MG : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 27.00;
        }
    }
}