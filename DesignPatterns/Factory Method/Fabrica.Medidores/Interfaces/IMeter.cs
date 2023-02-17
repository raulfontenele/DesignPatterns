using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica.Medidores.Interfaces
{
    public interface IMeter
    {
        public void LerEnergia(string tipoAtivo, string tipoReativo, string tarifa);
        public void LerDemanda(string tipoAtivo, string tipoReativo, string tarifa);
        public void EscreverEnergia(string tipoAtivo, string tipoReativo, string tarifa, double valor);
    }
}
