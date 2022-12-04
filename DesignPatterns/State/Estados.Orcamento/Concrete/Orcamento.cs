using Estados.Orcamento.Concrete.States;
using Estados.Orcamento.Interfaces;

namespace Estados.Orcamento.Concrete
{
    public class Orcamento : IOrcamento
    {
        private IEstadosOrcamento _estado;
        private decimal _valor;

        public Orcamento(decimal valor)
        {
            _valor = valor;
            _estado = new EstadoEmAprovacao();
        }

        public (TiposEstados estadoAtual, bool confirmacao) Aprovar()
        {
            (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao)  = _estado.Aprovar();

            if (confirmacao)
                _estado = estadoAtual;
            return (tipoEstado, confirmacao);

        }

        public (TiposEstados estadoAtual, bool confirmacao) Finalizar()
        {
            (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) = _estado.Finalizar();

            if (confirmacao)
                _estado = estadoAtual;
            return (tipoEstado, confirmacao);
        }

        public (TiposEstados estadoAtual, bool confirmacao) Reprovar()
        {
            (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) = _estado.Reprovar();

            if (confirmacao)
                _estado = estadoAtual;
            return (tipoEstado, confirmacao);
        }

        public decimal Valor()
        {
            return _valor;
        }
        public decimal AplicarDesconto()
        {
            decimal desconto = _estado.ObterDesconto(_valor);
            _valor -= desconto;
            return desconto;
        }
    }
}
