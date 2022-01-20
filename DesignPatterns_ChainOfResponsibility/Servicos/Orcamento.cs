using DesignPatterns_ChainOfResponsibility.Models;
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

        private void AdcionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}