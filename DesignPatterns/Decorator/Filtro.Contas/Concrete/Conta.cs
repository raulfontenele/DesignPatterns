using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtros.Contas.Concrete
{
    public class Conta
    {
        public Conta(string nome, decimal saldo, DateTime dataAbertura)
        {
            Nome = nome;
            Saldo = saldo;
            DataAbertura = dataAbertura;
        }

        public string Nome { get; private set; }
        public decimal Saldo { get; private set; }
        public DateTime DataAbertura { get; private set; }


    }
}
