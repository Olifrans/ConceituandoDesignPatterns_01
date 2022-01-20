using DesignPatterns_Strategy.Servicos;

namespace DesignPatterns_Strategy.Interface
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}