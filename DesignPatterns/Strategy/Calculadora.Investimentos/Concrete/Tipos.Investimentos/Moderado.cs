using Calculadora.Investimentos.Interfaces;

namespace Calculadora.Investimentos.Concrete.Tipos.Investimentos
{
    public class Moderado : IInvestimento
    {
        private const int PROBABILIDADEMAXIMO = 50;
        public decimal RealizarInvestimento(decimal valor)
        {
            if(new Random().Next(101) >= PROBABILIDADEMAXIMO)
                return valor * 2.5m / 100;

            return valor * 0.7m / 100;

        }
    }
}
