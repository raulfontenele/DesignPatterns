using Cadeia.Tipos.Requisicoes.Domain.TiposRequisicao;
using Cadeia.Tipos.Requisicoes.Extensions;
using Cadeia.Tipos.Requisicoes.Interfaces;

namespace Cadeia.Tipos.Requisicoes.Domain
{
    public static class ConstrutorCadeia
    {
        public static string RealizarRequisicao(IConta conta, Requisicao requisicao)
        {
            var req1 = new RequisicaoCSV();
            var req2 = new RequisicaoXML();
            var req3 = new RequisicaoPorcento();

            req1.Proximo = req2;
            req2.Proximo = req3;

            return req1.Processar(conta, requisicao);
            
        }
    }
}
