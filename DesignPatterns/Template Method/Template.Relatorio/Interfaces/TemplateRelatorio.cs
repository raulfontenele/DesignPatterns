using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Relatorio.Concrete;

namespace Template.Relatorio.Interfaces
{
    public abstract class TemplateRelatorio : IRelatorio
    {
        protected IBanco _banco;

        public TemplateRelatorio(IBanco banco)
        {
            _banco = banco;
        }

        public void ImprimirRelatorio()
        {
            ImprimirCabecalho();
            ImprimirCorpo();
            ImprimirRodape();
        }
        protected abstract void ImprimirCabecalho();
        protected abstract void ImprimirCorpo();
        protected abstract void ImprimirRodape();
    }
}
