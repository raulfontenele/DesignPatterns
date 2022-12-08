using Calculadora.Descontos.Interfaces;
using Calculadora.Descontos.Concrete.TiposDescontos;

namespace Calculadora.Descontos.Concrete
{
    public class CalculadoraDescontos
    {
        private IOrcamento _orcamento;
        
        public CalculadoraDescontos(IOrcamento orcamento)
        {
            _orcamento = orcamento;
        }
        
        public decimal CalcularDesconto()
        {
            DescontoMaisCincoItens d1 = new();
            DescontoMaiorQuinhetos d2 = new();

            d1.Proximo = d2;

            return d1.Desconta(_orcamento);

        }
    }
}
