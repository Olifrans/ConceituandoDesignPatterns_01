using DesignPatterns_Strategy.Interface;
using DesignPatterns_Strategy.Servicos;

namespace DesignPatterns_Strategy.ImpostosMunicipais
{
    public class ISS_SP : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 5.00;
        }
    }
}