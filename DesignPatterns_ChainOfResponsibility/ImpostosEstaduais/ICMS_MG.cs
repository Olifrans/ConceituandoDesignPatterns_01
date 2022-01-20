using DesignPatterns_ChainOfResponsibility.Interface;
using DesignPatterns_ChainOfResponsibility.Servicos;

namespace DesignPatterns_ChainOfResponsibility.ImpostosEstaduais
{
    public class ICMS_MG : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 27.00;
        }
    }
}