using Calculadora.Imposto.Interfaces;

namespace Calculadora.Imposto.Concrete.Impostos
{
    //Nome fictício para testar uma nova regra de negócio de cálculo de imposto
    public class ICCC : IImposto
    {
        public decimal Calcular(IOrcamento orcamento)
        {
            if (orcamento.Valor() < 1000)
                return orcamento.Valor() * 5 / 100;
            else if(orcamento.Valor() <= 3000)
                return orcamento.Valor() * 7 / 100;
            else
                return orcamento.Valor() * 8 / 100 + 30;
        }
    }
}
