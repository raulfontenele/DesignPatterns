using System;
using Template.Relatorio.Concrete;

namespace Template.Relatorio.Interfaces
{
    public interface IBanco
    {
        string Nome { get;}
        string Enderenco { get; }
        string Email { get; }
        uint Telefone { get; }
        IEnumerable<Conta> Contas { get; }
        void AdicionarContas(Conta conta);
    }
}