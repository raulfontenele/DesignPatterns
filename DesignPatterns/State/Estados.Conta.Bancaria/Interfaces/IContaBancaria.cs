using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estados.Conta.Bancaria.Interfaces
{
    public interface IContaBancaria
    {
        decimal Saldo();
        decimal RealizarSaque(decimal valor);
        decimal RealizarDeposito(decimal valor);
    }
}
