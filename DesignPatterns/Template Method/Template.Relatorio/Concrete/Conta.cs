using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Relatorio.Concrete
{
    public class Conta
    {
        public string NomeTitular { get; private set; }
        public uint Agencia { get; private set; }
        public uint Numero { get; private set; }
        public decimal Saldo { get; private set; }

        public Conta(string nomeTitular, uint agencia, uint numero, decimal saldo)
        {
            NomeTitular = nomeTitular;
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
        }
    }
}
