using DesignPatterns_ChainOfResponsibility.Servicos;

namespace DesignPatterns_ChainOfResponsibility.Interface
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}