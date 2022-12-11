using Calculadora.Investimentos.Interfaces;

namespace Calculadora.Investimentos.Concrete.Tipos.Investimentos
{
    public class Arrojado : IInvestimento
    {
        private const int PROBABILIDADEMAXIMO = 80;
        private const int PROBABILIDADEMEDIA = 50;
        public decimal RealizarInvestimento(decimal valor)
        {
            int probabilidade = new Random().Next(101);
            if(probabilidade >= PROBABILIDADEMAXIMO)
                return valor * 5 / 100;
            else if(probabilidade >= PROBABILIDADEMEDIA)
                return valor * 3 / 100;

            return valor * 0.5m / 100;
        }
    }
}
