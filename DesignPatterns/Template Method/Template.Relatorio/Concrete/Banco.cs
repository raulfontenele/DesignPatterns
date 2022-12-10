using Template.Relatorio.Interfaces;

namespace Template.Relatorio.Concrete
{
    public class Banco : IBanco
    {
        private readonly string _nome;
        private readonly string _enderenco;
        private readonly string _email;
        private readonly uint _telefone;
        private List<Conta> _contas;

        
        public string Nome => _nome;

        public string Enderenco => _enderenco;

        public string Email => _email;

        public uint Telefone => _telefone;

        public IEnumerable<Conta> Contas => _contas.AsEnumerable();

        public Banco(string nome, string enderenco, string email, uint telefone)
        {
            _nome = nome;
            _enderenco = enderenco;
            _email = email;
            _telefone = telefone;
            _contas = new List<Conta>();
        }

        public void AdicionarContas(Conta conta)
        {
            _contas.Add(conta);
        }
    }
}
