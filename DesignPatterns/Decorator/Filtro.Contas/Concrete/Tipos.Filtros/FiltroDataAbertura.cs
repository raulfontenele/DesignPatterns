using Filtros.Contas.Abstract;

namespace Filtros.Contas.Concrete.Tipos.Filtros
{
    public class FiltroDataAbertura : Filtro
    {
        public FiltroDataAbertura() : base() { }
        public FiltroDataAbertura(Filtro proximo) : base(proximo)
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return (List<Conta>)contas.Where(i => i.DataAbertura.Month == DateTime.Now.Month).ToList().
                Concat((Proximo != null) ? Proximo.Filtra(contas) : new List<Conta>()).ToList();
        }
    }
}
