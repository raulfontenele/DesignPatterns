using Template.Imposto.Concrete;
using Template.Imposto.Interfaces;

namespace Template.Imposto.Concrete.Impostos
{
    public class IKCV : TemplateImposto
    {
        private readonly int MAXIMOPERCENTUAL = 10;
        private readonly int MINIMOPERCENTUAL = 7;
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
            if(orcamento.Valor() < 500)
                return false;

            foreach(var item in orcamento.GetItens())
            {
                if(item.Valor > 100)
                    return true;
            }
            return false;
        }
    }
}
