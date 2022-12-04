using Estados.Conta.Bancaria.Interfaces;

namespace Estados.Conta.Bancaria.Concrete.States
{
    public class ContaNegativa : IEstadoBancario
    {
        public decimal RealizarDeposito(decimal valor)
        {
            return valor * 95 / 100;
        }

        public decimal RealizarSaque(decimal valor)
        {
            return 0;
        }
    }
}