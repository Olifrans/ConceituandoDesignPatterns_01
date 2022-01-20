using DesignPatterns_ChainOfResponsibility.Interface;
using System;

namespace DesignPatterns_ChainOfResponsibility.Servicos
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