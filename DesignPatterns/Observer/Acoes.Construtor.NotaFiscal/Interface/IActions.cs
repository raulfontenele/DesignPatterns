using Acoes.Construtor.NotaFiscal.Domain;

namespace Acoes.Construtor.NotaFiscal.Interface
{
    internal interface IAcoesNotaFiscal
    {
        public void Executar(INotaFiscal notaFiscal);
    }
}
