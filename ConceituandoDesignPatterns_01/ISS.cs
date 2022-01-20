namespace ConceituandoDesignPatterns_01
{
    public class ISS
    {
        public double CalculoISS(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}