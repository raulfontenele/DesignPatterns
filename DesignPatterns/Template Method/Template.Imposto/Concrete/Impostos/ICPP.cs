using Template.Imposto.Concrete;
using Template.Imposto.Interfaces;

namespace Template.Imposto.Concrete.Impostos
{
    public class ICPP : TemplateImposto
    {
        private readonly int MAXIMOPERCENTUAL = 7;
        private readonly int MINIMOPERCENTUAL = 5;

        protected override decimal CalcularValorMaximo(IOrcamento orcamento)
        {
            return orcamento.Valor() * MAXIMOPERCENTUAL / 100;
        }

        protected override decimal CalcularValorMinimo(IOrcamento orcamento)
        {
            return orcamento.Valor() * MINIMOPERCENTUAL / 100;
        }

        protected override bool CondionalValorMaximo(IOrcamento orcamento)
        {
            return orcamento.Valor() >= 500;
        }
    }
}
