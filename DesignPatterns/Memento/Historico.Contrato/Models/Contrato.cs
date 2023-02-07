using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historico.Contrato.Models
{
    public class Contrato
    {
        public string Cliente { get; private set; }
        public DateTime DataAbertura { get; private set; }
        public ContratoStatus Estado { get; private set; }

        public Contrato(string cliente)
        {
            Cliente = cliente;
            DataAbertura = DateTime.Now;
            Estado = ContratoStatus.Novo;
        }
        private Contrato(string cliente, DateTime dataAbertura, ContratoStatus estado)
        {
            Cliente = cliente;
            DataAbertura = dataAbertura;
            Estado = estado;
        }

        public void AvancarEstado()
        {
            if (Estado == ContratoStatus.Novo) Estado = ContratoStatus.EmAndamento;
            else if (Estado == ContratoStatus.EmAndamento) Estado = ContratoStatus.Finalizado;
        }

        public Contrato EstadoAtual()
        {
            return new Contrato(this.Cliente, this.DataAbertura, this.Estado);
        }
    }

    public enum ContratoStatus
    {
        Novo,
        EmAndamento,
        Finalizado
    }
}
