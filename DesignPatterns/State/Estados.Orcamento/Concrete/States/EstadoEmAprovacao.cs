using Estados.Orcamento.Interfaces;

namespace Estados.Orcamento.Concrete.States
{
    public class EstadoEmAprovacao : IEstadosOrcamento
    {
        private bool _descontoAplicado;
        public EstadoEmAprovacao()
        {
            this._descontoAplicado = false;
        }
        public (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Aprovar()
        {
            return (new EstadoAprovado(), TiposEstados.APROVADO, true);
        }

        public (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Finalizar()
        {
            return (this, TiposEstados.EM_APROVACAO, false);
        }

        public (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Reprovar()
        {
            return (this, TiposEstados.EM_APROVACAO, false);
        }
        public decimal ObterDesconto(decimal valorOrcamento)
        {
            if (_descontoAplicado)
                return 0;

            _descontoAplicado = true;
            return valorOrcamento * 5 / 100;
        }


    }
}
