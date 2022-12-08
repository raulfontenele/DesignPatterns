
namespace Calculadora.Descontos.Interfaces
{
    public interface IDesconto
    {
        decimal Desconta(IOrcamento orcamento);
        IDesconto? Proximo { get; set; }
    }
}
