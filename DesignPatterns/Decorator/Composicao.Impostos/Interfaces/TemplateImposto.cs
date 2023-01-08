using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Imposto.Interfaces
{
    public abstract class TemplateImposto : IImposto
    {
        protected IImposto? _outroImposto;
        public TemplateImposto() 
        {
            _outroImposto = null;
        }
        public TemplateImposto(IImposto outroImposto) 
        {
            _outroImposto = outroImposto;
        }
        public decimal Calcular(IOrcamento orcamento)
        {
            if (CondionalValorMaximo(orcamento))
                return CalcularValorMaximo(orcamento) + CalculoOutroImposto(orcamento);

            return CalcularValorMinimo(orcamento) + CalculoOutroImposto(orcamento);
        } 
        
        protected decimal CalculoOutroImposto(IOrcamento orcamento)
        {
            return _outroImposto != null ? _outroImposto.Calcular(orcamento) : 0;
        }

        protected abstract bool CondionalValorMaximo(IOrcamento orcamento);
        protected abstract decimal CalcularValorMaximo(IOrcamento orcamento);
        protected abstract decimal CalcularValorMinimo(IOrcamento orcamento);

    }
}
