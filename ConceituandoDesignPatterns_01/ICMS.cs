namespace ConceituandoDesignPatterns_01
{
    public class ICMS
    {
        public double CalculoICMS(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}