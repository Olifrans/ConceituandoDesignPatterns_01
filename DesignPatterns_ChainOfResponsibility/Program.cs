using DesignPatterns_ChainOfResponsibility.Entidades;
using DesignPatterns_ChainOfResponsibility.Servicos;
using DesignPatterns_Strategy.Servicos;
using System;

namespace DesignPatterns_ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            //adção de Itens
            orcamento.AdcionaItem(new Item("Rodas", 250));
            orcamento.AdcionaItem(new Item("Discos", 250));
            orcamento.AdcionaItem(new Item("Geladeira", 4250));
            orcamento.AdcionaItem(new Item("Televisão", 2250));
            orcamento.AdcionaItem(new Item("Notbook", 3250));
            orcamento.AdcionaItem(new Item("Ar Condicionado", 1250));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }
    }
}
