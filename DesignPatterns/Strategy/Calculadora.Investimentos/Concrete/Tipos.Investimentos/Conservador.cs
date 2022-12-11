using Calculadora.Investimentos.Interfaces;

namespace Calculadora.Investimentos.Concrete.Tipos.Investimentos
{
    public class Conservador : IInvestimento
    {
        public decimal RealizarInvestimento(decimal valor)
        {
            return valor * 0.8m / 100;
        }
    }
}
