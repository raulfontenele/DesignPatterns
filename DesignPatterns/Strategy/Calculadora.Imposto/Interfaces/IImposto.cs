using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Imposto.Interfaces
{
    public interface IImposto
    {
        public decimal Calcular(IOrcamento orcamento);
    }
}
