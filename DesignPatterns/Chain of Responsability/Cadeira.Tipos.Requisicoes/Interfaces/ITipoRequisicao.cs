using Cadeia.Tipos.Requisicoes.Domain;

namespace Cadeia.Tipos.Requisicoes.Interfaces
{
    public interface ITipoRequisicao
    {
        string Processar(IConta conta, Requisicao requisicao);
        ITipoRequisicao? Proximo { get; set; }
    }
}
