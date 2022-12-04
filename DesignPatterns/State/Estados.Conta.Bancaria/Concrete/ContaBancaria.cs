using Estados.Conta.Bancaria.Interfaces;
using Estados.Conta.Bancaria.Concrete.States;

namespace Estados.Conta.Bancaria.Concrete
{
    public class ContaBancaria : IContaBancaria
    {
        private decimal _saldo;
        private IEstadoBancario _estado;

        public ContaBancaria(IEstadoBancario estado)
        {
            _saldo = 0;
            _estado = estado;
        }

        public decimal RealizarDeposito(decimal valor)
        {
            _saldo += _estado.RealizarDeposito(valor);

            if (_saldo >= 0 && _estado.GetType() != typeof(ContaPositiva))
                _estado = new ContaPositiva();

            return _saldo;
        }

        public decimal RealizarSaque(decimal valor)
        {
            _saldo -= _estado.RealizarSaque(valor);

            if(_saldo < 0 && _estado.GetType() != typeof(ContaNegativa))
                _estado = new ContaNegativa();

            return _saldo;
        }

        public decimal Saldo()
        {
            return _saldo;
        }
    }
}
