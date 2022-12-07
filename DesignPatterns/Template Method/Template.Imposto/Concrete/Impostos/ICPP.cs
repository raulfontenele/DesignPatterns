using Template.Imposto.Concrete;
using Template.Imposto.Interfaces;

namespace Template.Imposto.Concrete.Impostos
{
    public class ICPP : TemplateImposto
    {
        private readonly int MAXIMOPERCENTUAL = 7;
        private readonly int MINIMOPERCENTUAL = 5;

        public override decimal CalcularValorMaximo(decimal valor)
        {
            return valor * MAXIMOPERCENTUAL / 100;
        }

        public override decimal CalcularValorMinimo(decimal valor)
        {
            return valor * MINIMOPERCENTUAL / 100;
        }

        public override bool CondionalValorMaximo(IOrcamento orcamento)
        {
            return orcamento.Valor() >= 500;
        }
    }
}
