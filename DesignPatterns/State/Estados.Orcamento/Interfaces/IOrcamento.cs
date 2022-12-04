using Estados.Orcamento.Concrete.States;

namespace Estados.Orcamento.Interfaces
{
    public interface IOrcamento
    {
        decimal Valor();
        decimal AplicarDesconto();
        (TiposEstados estadoAtual, bool confirmacao) Aprovar();
        (TiposEstados estadoAtual, bool confirmacao) Reprovar();
        (TiposEstados estadoAtual, bool confirmacao) Finalizar();
    }
}
