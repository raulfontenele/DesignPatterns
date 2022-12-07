using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Imposto.Concrete
{
    public class Item
    {
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public Item(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
