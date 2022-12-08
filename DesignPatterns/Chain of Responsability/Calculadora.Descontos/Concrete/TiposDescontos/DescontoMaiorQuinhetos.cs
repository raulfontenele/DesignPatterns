using Calculadora.Descontos.Interfaces;

namespace Calculadora.Descontos.Concrete.TiposDescontos
{
    public class DescontoMaiorQuinhetos : IDesconto
    {
        private readonly decimal PERCENTUALDESCONTO = 7;
        private IDesconto _proximo;
        public IDesconto Proximo
        {
            get => _proximo;
            set => _proximo = value;
        }

        public decimal Desconta(IOrcamento orcamento)
        {
            if (orcamento.Valor > 500)
                return orcamento.Valor * PERCENTUALDESCONTO / 100;

            return _proximo != null ? _proximo.Desconta(orcamento) : 0;
        }
    }
}