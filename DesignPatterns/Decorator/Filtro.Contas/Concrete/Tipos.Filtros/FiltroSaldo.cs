using Filtros.Contas.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtros.Contas.Concrete.Tipos.Filtros
{
    public class FiltroSaldo : Filtro
    {
        private const decimal SALDOMAXIMO = 500000;
        private const decimal SALDOMINIMO = 100;
        public FiltroSaldo() : base() { }
        public FiltroSaldo(Filtro proximo) : base(proximo)
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return (List<Conta>)contas.Where(i => i.Saldo < SALDOMINIMO || i.Saldo > SALDOMAXIMO).ToList().
                Concat((Proximo!=null) ? Proximo.Filtra(contas) : new List<Conta>()).ToList();
        }
    }
}
