using Calculadora.Descontos.Concrete;
using Calculadora.Descontos.Interfaces;

IOrcamento orcamento = new Orcamento();

CalculadoraDescontos calculadoraDesconto = new(orcamento);

Console.WriteLine($"O valor de desconto sem adicionar itens é R${calculadoraDesconto.CalcularDesconto()} para um orçamento de {orcamento.Valor}");

orcamento.AdicionarItem(new Item("Objeto 1", 100));
orcamento.AdicionarItem(new Item("Objeto 2", 200));
orcamento.AdicionarItem(new Item("Objeto 3", 300));
orcamento.AdicionarItem(new Item("Objeto 4", 400));

Console.WriteLine($"O valor de desconto após adicionar quatro itens é R${calculadoraDesconto.CalcularDesconto()} para um orçamento de {orcamento.Valor}");

orcamento.AdicionarItem(new Item("Objeto 5", 500));
orcamento.AdicionarItem(new Item("Objeto 6", 600));

Console.WriteLine($"O valor de desconto após adicionar seis itens é R${calculadoraDesconto.CalcularDesconto()} para um orçamento de {orcamento.Valor}");



