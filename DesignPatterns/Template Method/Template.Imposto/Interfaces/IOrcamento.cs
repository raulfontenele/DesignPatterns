using Template.Imposto.Concrete;

namespace Template.Imposto.Interfaces
{
    public interface IOrcamento
    {
        decimal Valor();
        bool AdicionarItem(Item item);
        IEnumerable<Item> GetItens();
    }
}
