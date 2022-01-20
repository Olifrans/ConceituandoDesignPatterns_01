using DesignPatterns_ChainOfResponsibility.Interface;
using DesignPatterns_ChainOfResponsibility.Servicos;

namespace DesignPatterns_ChainOfResponsibility.ImpostosMunicipais
{
    public class ISS_SP : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 5.00;
        }
    }
}