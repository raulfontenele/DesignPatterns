using Cadeia.Tipos.Requisicoes.Interfaces;
using Cadeia.Tipos.Requisicoes.Extensions;

namespace Cadeia.Tipos.Requisicoes.Domain.TiposRequisicao
{
    public class RequisicaoPorcento : ITipoRequisicao
    {
        private ITipoRequisicao? _proximo;
        public ITipoRequisicao? Proximo
        {
            get => _proximo;
            set => _proximo = value;
        }

        public string Processar(IConta conta, Requisicao requisicao)
        {
            if (requisicao.Formato.Equals(Formato.PORCENTO))
                return $"{conta.Nome}%{conta.Saldo}";

            return _proximo != null ? _proximo.Processar(conta, requisicao) : "";
        }
    }
}
