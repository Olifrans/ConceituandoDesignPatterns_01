using DesignPatterns_ChainOfResponsibility.Servicos;

namespace DesignPatterns_Strategy.Servicos
{
    public class DescontosPorMaisDeQuinhentosReais
    {
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 500)
            {
                return orcamento.Valor * 0.07;
            }           
            return 0;     
        }       
    }
}