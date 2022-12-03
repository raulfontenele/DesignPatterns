using Calculadora.Imposto.Interfaces;

namespace Calculadora.Imposto.Concrete
{
    public class CalculadoraImposto
    {
        public decimal Calcular(IOrcamento orcamento, IImposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
