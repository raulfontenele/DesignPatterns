using Cadeia.Tipos.Requisicoes.Interfaces;

namespace Cadeia.Tipos.Requisicoes.Domain
{
    public class Conta : IConta
    {
        private readonly string _nome;
        private readonly string _cpf;
        private readonly string _telefone;

        public Conta(string nome, string cpf, string telefone)
        {
            _nome = nome;
            _cpf = cpf;
            _telefone = telefone;
        }

        public string Nome { 
            get => _nome;
        }
        public string CPF { 
            get => _cpf;
        }
        public string Telefone {
            get => _telefone;
        }
    }
}
