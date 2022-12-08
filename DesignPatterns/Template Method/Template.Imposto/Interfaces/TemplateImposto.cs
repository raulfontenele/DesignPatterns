using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Imposto.Interfaces
{
    public abstract class TemplateImposto : IImposto
    {
        public decimal Calcular(IOrcamento orcamento)
        {
            if (CondionalValorMaximo(orcamento))
                return CalcularValorMaximo(orcamento.Valor());

            return CalcularValorMinimo(orcamento.Valor());
        } 
        
        public abstract bool CondionalValorMaximo(IOrcamento orcamento);
        public abstract decimal CalcularValorMaximo(decimal valor);
        public abstract decimal CalcularValorMinimo(decimal valor);

    }
}
