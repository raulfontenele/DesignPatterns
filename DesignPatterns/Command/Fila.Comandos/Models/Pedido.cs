using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila.Comandos.Models
{
    public class Pedido
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public Status Status { get; private set; }
        public DateTime DataFinalizacao { get; private set; }

        public Pedido(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Status = Status.Novo;
        }

        public void Paga()
        {
            Status = Status.Pago;
            Console.WriteLine($"O pedido do cliente {Cliente} foi pago!");
        }

        public void Finaliza()
        {
            DataFinalizacao = DateTime.Now;
            Status = Status.Entregue;
            Console.WriteLine($"O pedido do cliente {Cliente} foi finalizado!");
        }
    }

    public enum Status
    {
        Novo,
        Processado,
        Pago,
        ItemSeparado,
        Entregue
    }
}
