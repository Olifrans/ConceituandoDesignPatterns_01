using DesignPatterns_ChainOfResponsibility.Entidades;
using System.Collections.Generic;

namespace DesignPatterns_ChainOfResponsibility.Servicos
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdcionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}