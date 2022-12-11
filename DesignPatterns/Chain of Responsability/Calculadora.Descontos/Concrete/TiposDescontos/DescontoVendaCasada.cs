using Calculadora.Descontos.Interfaces;


namespace Calculadora.Descontos.Concrete.TiposDescontos
{
    public class DescontoVendaCasada : IDesconto
    {
        private readonly decimal PERCENTUALDESCONTO = 5;
        private IDesconto? _proximo;
        public IDesconto Proximo
        {
            get => _proximo;
            set => _proximo = value;
        }

        public decimal Desconta(IOrcamento orcamento)
        {
            if(Existe("LAPIS", orcamento) && Existe("CANETA", orcamento))
                return orcamento.Valor * PERCENTUALDESCONTO / 100;

            return _proximo != null ? _proximo.Desconta(orcamento) : 0;
        }

        private bool Existe(String nomeDoItem, IOrcamento orcamento)
        {
            foreach (Item item in orcamento.GetItems())
            {
                if (item.Nome.ToLower().Equals(nomeDoItem.ToLower()))
                    return true;
            }
            return false;
        }
    }
}
