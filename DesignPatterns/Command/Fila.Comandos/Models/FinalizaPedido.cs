using Fila.Comandos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila.Comandos.Models
{
    public class FinalizaPedido : ICommand
    {
        private Pedido _pedido;
        public FinalizaPedido(Pedido pedido)
        {
            _pedido = pedido;
        }
        public void Executa()
        {
            _pedido.Finaliza();
        }
    }
}
