using Acoes.Construtor.NotaFiscal.Interface;

namespace Acoes.Construtor.NotaFiscal.Domain
{
    public class Multiplicador : IAcoesNotaFiscal
    {
        public double Fator { get; private set; }
        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }

        public void Executar(INotaFiscal notaFiscal)
        {
            Console.WriteLine($"Valor da nota multiplicada por fator de {Fator} é {notaFiscal.ValorBruto * Fator}") ;
        }
    }
}
