using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.XML.Model
{
    public class Cliente
    {
        public Cliente() { }
        public Cliente(string nome, string telefone, string cPF)
        {
            Nome = nome;
            Telefone = telefone;
            CPF = cPF;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
    }
}
