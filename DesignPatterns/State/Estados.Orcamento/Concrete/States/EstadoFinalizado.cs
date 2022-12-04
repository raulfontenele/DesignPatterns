using Estados.Orcamento.Interfaces;

namespace Estados.Orcamento.Concrete.States
{
    public class EstadoFinalizado : IEstadosOrcamento
    {
        public (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Aprovar()
        {
            return (this, TiposEstados.FINALIZADO, false);
        }

        public (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Finalizar()
        {
            return (this, TiposEstados.FINALIZADO, false);
        }

        public (IEstadosOrcamento estadoAtual, TiposEstados tipoEstado, bool confirmacao) Reprovar()
        {
            return (this, TiposEstados.FINALIZADO, false);
        }

        public decimal ObterDesconto(decimal valorOrcamento)
        {
            return 0;
        }

    }
}