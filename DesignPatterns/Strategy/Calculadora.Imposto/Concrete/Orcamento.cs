using Calculadora.Imposto.Interfaces;

namespace Calculadora.Imposto.Concrete
{
    public class Orcamento : IOrcamento
    {
        private decimal _valor;
        public Orcamento(Decimal valor)
        {
            _valor = valor;
        }
        public decimal Valor() { return _valor; }
    }
}
