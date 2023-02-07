using Filtros.Contas.Concrete;

namespace Filtros.Contas.Abstract
{
    public abstract class Filtro
    {
        public Filtro() 
        {
            Proximo = null;
        }
        public Filtro(Filtro proximo)
        {
            Proximo = proximo;
        }

        protected Filtro Proximo { get; private set; }
        public abstract IList<Conta> Filtra(IList<Conta> contas);
    }
}
