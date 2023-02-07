using Cadeia.Tipos.Requisicoes.Interfaces;
using Cadeia.Tipos.Requisicoes.Extensions;

namespace Cadeia.Tipos.Requisicoes.Domain.TiposRequisicao
{
    public class RequisicaoXML : ITipoRequisicao
    {
        private ITipoRequisicao? _proximo;
        public ITipoRequisicao? Proximo { 
            get => _proximo; 
            set => _proximo = value; 
        }

        public string Processar(IConta conta, Requisicao requisicao)
        {
            if(requisicao.Formato.Equals(Formato.XML))
                return $"<requisicao>" +
                    $"<nome>{conta.Nome}</nome>" +
                    $"<saldo>{conta.Saldo}</saldo>" +
                    $"</requisicao>";
            
            return _proximo != null ? _proximo.Processar(conta, requisicao) : "";
        }
    }
}
