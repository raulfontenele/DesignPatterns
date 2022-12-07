using Template.Imposto.Interfaces;

namespace Template.Imposto.Concrete
{
    public class Orcamento : IOrcamento
    {
        private List<Item> _itens;
        private decimal _valor;
        public Orcamento()
        {
            _itens = new List<Item>();
            _valor = 0;
        }
        public bool AdicionarItem(Item item)
        {
            _itens.Add(item);
            return true;
        }

        public IEnumerable<Item> GetItens()
        {
            return _itens.AsEnumerable();
        }

        public decimal Valor()
        {
            return _valor;
        }
    }
}
