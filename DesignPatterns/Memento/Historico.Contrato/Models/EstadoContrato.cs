using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historico.Contrato.Models
{
    public class EstadoContrato
    {
        public Contrato Contrato { get; private set; }
        public DateTime DataAlteracao { get; private set; }

        public EstadoContrato(Contrato contrato)
        {
            this.Contrato = contrato;
            this.DataAlteracao = DateTime.Now;
        }
    }
}
