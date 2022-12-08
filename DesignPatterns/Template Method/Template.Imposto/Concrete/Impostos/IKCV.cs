using Template.Imposto.Concrete;
using Template.Imposto.Interfaces;

namespace Template.Imposto.Concrete.Impostos
{
    public class IKCV : TemplateImposto
    {
        private readonly int MAXIMOPERCENTUAL = 10;
        private readonly int MINIMOPERCENTUAL = 7;
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
