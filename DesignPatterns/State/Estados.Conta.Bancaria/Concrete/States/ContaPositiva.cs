using Estados.Conta.Bancaria.Interfaces;

namespace Estados.Conta.Bancaria.Concrete.States
{
    public class ContaPositiva : IEstadoBancario
    {
        public decimal RealizarDeposito(decimal valor)
        {
            return valor * 98 / 100;
        }

        public decimal RealizarSaque(decimal valor)
        {
            return valor;
        }
    }
}
