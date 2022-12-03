using Calculadora.Imposto.Interfaces;

namespace Calculadora.Imposto.Concrete.Impostos
{
    public class ICMS : IImposto
    {
        public decimal Calcular(IOrcamento orcamento)
        {
            return orcamento.Valor() * 5 / 100 + 50;
        }
    }
}
