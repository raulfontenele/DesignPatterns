using Acoes.Construtor.NotaFiscal;
using Acoes.Construtor.NotaFiscal.Interface;

namespace Acoes.Construtor.NotaFiscal.Domain
{
    public class SalvarDados : IAcoesNotaFiscal
    {

        public void Executar(INotaFiscal notaFiscal)
        {
            Console.WriteLine("Salvando dados ...");
        }
    }
}
