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
                return CalcularValorMaximo(orcamento);

            return CalcularValorMinimo(orcamento);
        } 
        
        protected abstract bool CondionalValorMaximo(IOrcamento orcamento);
        protected abstract decimal CalcularValorMaximo(IOrcamento orcamento);
        protected abstract decimal CalcularValorMinimo(IOrcamento orcamento);

    }
}
