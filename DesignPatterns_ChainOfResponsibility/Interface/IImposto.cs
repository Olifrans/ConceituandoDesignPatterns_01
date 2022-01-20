using DesignPatterns_ChainOfResponsibility.Servicos;

namespace DesignPatterns_ChainOfResponsibility.Interface
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}