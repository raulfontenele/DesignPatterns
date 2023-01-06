using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadeia.Tipos.Requisicoes.Interfaces
{
    public interface IConta
    {
        string Nome { get; }
        string CPF { get; }
        string Telefone { get; }
    }
}
