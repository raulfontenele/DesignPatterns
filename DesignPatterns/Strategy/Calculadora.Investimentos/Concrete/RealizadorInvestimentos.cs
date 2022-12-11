using Calculadora.Investimentos.Interfaces;

namespace Calculadora.Investimentos.Concrete
{
    public static class RealizadorInvestimentos
    {
        private const uint PERCENTUALSEMIMPOSTO = 75;
        public static decimal RealizarInvestimento(IConta conta, IInvestimento investimento)
        {
            return investimento.RealizarInvestimento(conta.Saldo) * PERCENTUALSEMIMPOSTO / 100;
        }
    }
}
