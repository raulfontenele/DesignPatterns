using Acoes.Construtor.NotaFiscal;
using Acoes.Construtor.NotaFiscal.Interface;

namespace Acoes.Construtor.NotaFiscal.Domain
{
    public class NotificarResponsaveis : IAcoesNotaFiscal
    {
        public void Executar(INotaFiscal notaFiscal)
        {
            Console.WriteLine("Notificando responsáveis ...");
        }
    }
}
