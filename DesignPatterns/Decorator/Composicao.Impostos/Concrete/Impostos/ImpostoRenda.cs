using Template.Imposto.Concrete;
using Template.Imposto.Interfaces;

namespace Composicao.Impostos.Concrete.Impostos
{
    public class ImpostoRenda : TemplateImposto
    {
        private readonly int MAXIMOPERCENTUAL = 20;
        public ImpostoRenda() : base() { }
        public ImpostoRenda(IImposto imposto) : base(imposto) { }

        protected override decimal CalcularValorMaximo(IOrcamento orcamento)
        {
            return orcamento.Valor() * MAXIMOPERCENTUAL / 100;
        }

        protected override decimal CalcularValorMinimo(IOrcamento orcamento)
        {
            return CalcularValorMaximo(orcamento);
        }

        protected override bool CondionalValorMaximo(IOrcamento orcamento)
        {
            return true;
        }
    }
}
