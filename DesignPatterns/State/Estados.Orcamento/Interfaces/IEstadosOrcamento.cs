using Estados.Orcamento.Concrete.States;

namespace Estados.Orcamento.Interfaces
{
    public interface IEstadosOrcamento
    {
        public decimal ObterDesconto(decimal valorOrcamento);
        (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Aprovar();
        (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Reprovar();
        (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Finalizar();

    }
}
