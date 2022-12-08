using Calculadora.Descontos.Interfaces;

namespace Calculadora.Descontos.Concrete.TiposDescontos
{
    public class DescontoMaisCincoItens : IDesconto
    {
        private readonly decimal PERCENTUALDESCONTO = 10;
        private IDesconto _proximo;
        public IDesconto Proximo { 
            get => _proximo;
            set => _proximo = value;
        }

        public decimal Desconta(IOrcamento orcamento)
        {
            if (orcamento.GetItems().Count > 5)
                return orcamento.Valor * PERCENTUALDESCONTO / 100;

            return _proximo != null ? _proximo.Desconta(orcamento) : 0;
        }
    }
}
