using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historico.Contrato.Models
{
    public class HistoricoContrato
    {
        private List<EstadoContrato> _estadoContratoList;
        public HistoricoContrato()
        {
            _estadoContratoList = new List<EstadoContrato>();
        }
        public void Adicionar(EstadoContrato estado)
        {
            _estadoContratoList.Add(estado);
        }
        public EstadoContrato Obter(int index)
        {
            if (_estadoContratoList.Count < index + 1)
                throw new ArgumentException("Invalid index");

            return _estadoContratoList[index];
        }
        public int NumeroEstados()
        {
            return _estadoContratoList.Count;
        }
    }
}
