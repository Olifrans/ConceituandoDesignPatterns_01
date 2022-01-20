using DesignPatterns_ChainOfResponsibility.Servicos;

namespace DesignPatterns_Strategy.Servicos
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            //Regra-01 --> mais de 05 itens
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            else if(orcamento.Itens.Count > 500.0)
            {
                return orcamento.Valor * 0.1;
            }
            return 0;

            //Regra-02 --> mais de 05 itens
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            else if (orcamento.Itens.Count > 500.0)
            {
                return orcamento.Valor * 0.1;
            }
            return 0;

            //Regra-03 --> mais de 05 itens
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            else if (orcamento.Itens.Count > 500.0)
            {
                return orcamento.Valor * 0.1;
            }
            return 0;

        }       
    }
}