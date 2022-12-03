using Calculadora.Imposto.Interfaces;

namespace Calculadora.Imposto.Concrete.Impostos
{
    public class ISS : IImposto
    {
        public decimal Calcular(IOrcamento orcamento)
        {
            return orcamento.Valor() * 6 / 100;
        }
    }
}