using Estados.Orcamento.Interfaces;

namespace Estados.Orcamento.Concrete.States
{
    public class EstadoAprovado : IEstadosOrcamento
    {
        private bool _descontoAplicado;
        public EstadoAprovado()
        {
            this._descontoAplicado = false;
        }
        public (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Aprovar()
        {
            return (this, TiposEstados.APROVADO, false);
        }
        public (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Finalizar()
        {
            return (new EstadoFinalizado(), TiposEstados.FINALIZADO, true);
        }
        public (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Reprovar()
        {
            return (this, TiposEstados.APROVADO, false);
        }
        public decimal ObterDesconto(decimal valorOrcamento)
        {
            if (_descontoAplicado)
                return 0;

            _descontoAplicado = true;
            return valorOrcamento * 2 / 100;
        }
    }
}