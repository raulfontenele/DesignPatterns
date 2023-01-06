using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoes.Construtor.NotaFiscal.Interface
{
    public interface INotaFiscal
    {
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
    }
}
