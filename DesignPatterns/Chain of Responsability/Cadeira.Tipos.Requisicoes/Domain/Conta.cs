using Cadeia.Tipos.Requisicoes.Interfaces;

namespace Cadeia.Tipos.Requisicoes.Domain
{
    public class Conta : IConta
    {
        private readonly string _nome;
        private readonly decimal _saldo;

        public Conta(string nome, decimal saldo)
        {
            _nome = nome;
            _saldo = saldo;
        }

        public string Nome { 
            get => _nome;
        }
        public decimal Saldo { 
            get => _saldo;
        }
    }
}
