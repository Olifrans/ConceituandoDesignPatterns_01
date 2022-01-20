using DesignPatterns_ChainOfResponsibility.Servicos;

namespace DesignPatterns_Strategy.Servicos
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            double aplicaDesconto = new DescontosPorCincoItens().Desconta(orcamento);
            if (aplicaDesconto == 0)
            {
                aplicaDesconto = new DescontosPorMaisDeQuinhentosReais().Desconta(orcamento);
            }
            // if(aplicaDesconto == 0) ...

            return 0;
        }
    }
}