using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Descontos.Concrete
{
    public class Item
    {
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public Item(string nome, decimal valor)
        {
            Valor = valor;
            Nome = nome;

            if (valor < 0)
                throw new ArgumentException("Valor inválido para um item");
        }
    }
}
