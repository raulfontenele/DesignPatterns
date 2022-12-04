using Estados.Orcamento.Interfaces;

namespace Estados.Orcamento.Concrete.States
{
    public class EstadoReprovado : IEstadosOrcamento
    {
        public (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Aprovar()
        {
            return (this, TiposEstados.REPROVADO, false);
        }

        public (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Finalizar()
        {
            return (new EstadoFinalizado(), TiposEstados.FINALIZADO, true);
        }

        public (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Reprovar()
        {
            return (this, TiposEstados.REPROVADO, false);
        }
        public decimal ObterDesconto(decimal valorOrcamento)
        {
            return 0;
        }

    }
}