using Calculadora.Descontos.Concrete;

namespace Calculadora.Descontos.Interfaces
{
    public interface IOrcamento
    {
        void AdicionarItem(Item item);
        List<Item> GetItems();
        decimal Valor { get; }

    }
}
