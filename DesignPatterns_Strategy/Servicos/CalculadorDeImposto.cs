using DesignPatterns_Strategy.Interface;
using System;

namespace DesignPatterns_Strategy.Servicos
{
    public class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double valorImposto = imposto.Calcula(orcamento);

            Console.WriteLine($"O valor do imposta é: {valorImposto}", +valorImposto);
        }
    }
}