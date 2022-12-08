using Calculadora.Descontos.Interfaces;


namespace Calculadora.Descontos.Concrete
{
    public class Orcamento : IOrcamento
    {
        private List<Item> _items;
        private decimal _valor;
        public decimal Valor { get => _valor; }

        public Orcamento()
        {
            _items = new List<Item>();
            _valor = 0;
        }
        public void AdicionarItem(Item item)
        {
            _items.Add(item);
            _valor += item.Valor;
        }

        public List<Item> GetItems()
        {
            return _items;
        }
    }
}
