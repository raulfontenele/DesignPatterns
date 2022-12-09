using Template.Imposto.Concrete;
using Template.Imposto.Interfaces;

namespace Template.Imposto.Concrete.Impostos
{
    public class IHIT : TemplateImposto
    {
        private readonly int MAXIMOPERCENTUAL = 13;
        private readonly int MINIMOPERCENTUAL = 1;

        protected override decimal CalcularValorMaximo(IOrcamento orcamento)
        {
            return orcamento.Valor() * MAXIMOPERCENTUAL / 100 + 100;
        }

        protected override decimal CalcularValorMinimo(IOrcamento orcamento)
        {
            return orcamento.Valor() * MINIMOPERCENTUAL * orcamento.GetItens().Count() / 100 ;
        }


        protected override bool CondionalValorMaximo(IOrcamento orcamento)
        {
            var itens = orcamento.GetItens();

            //Checar se existem valores duplicados
            return itens.GroupBy(item => item.Nome).Count() != itens.Distinct().Count();

        }
    }
}
