using Fila.Comandos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila.Comandos.Models
{
    public class PagaPedido : ICommand
    {
        private Pedido _pedido;
        public PagaPedido(Pedido pedido)
        {
            _pedido = pedido;
        } 
        public void Executa()
        {
            _pedido.Paga(); 
        }
    }
}
