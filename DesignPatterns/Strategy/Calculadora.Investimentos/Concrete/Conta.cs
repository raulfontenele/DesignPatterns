using Calculadora.Investimentos.Interfaces;

namespace Calculadora.Investimentos.Concrete
{
    public class Conta : IConta
    {
        private decimal _saldo;

        public Conta(decimal saldo)
        {
            _saldo = saldo;
        }

        public decimal Saldo => _saldo;
    }
}
