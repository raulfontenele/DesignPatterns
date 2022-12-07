using Template.Imposto.Concrete;
using Template.Imposto.Interfaces;
using Template.Imposto.Concrete.Impostos;

ICPP icpp = new();
IKCV ikcv = new();

IOrcamento orcamento = new Orcamento();

orcamento.AdicionarItem(new Item("ITEM 1", 100));
orcamento.AdicionarItem(new Item("ITEM 2", 200));

Console.WriteLine($"Orcamento com dois itens e valor total de R${orcamento.Valor()}");

Console.WriteLine($"O custo para o imposto do tipo ICPP foi de R${icpp.Calcular(orcamento)}");
Console.WriteLine($"O custo para o imposto do tipo ICPP foi de R${ikcv.Calcular(orcamento)}");

orcamento.AdicionarItem(new Item("ITEM 3", 50));
orcamento.AdicionarItem(new Item("ITEM 4", 120));

Console.WriteLine($"Orcamento com quatro itens e valor total de R${orcamento.Valor()}");

Console.WriteLine($"O custo para o imposto do tipo ICPP foi de R${icpp.Calcular(orcamento)}");
Console.WriteLine($"O custo para o imposto do tipo ICPP foi de R${ikcv.Calcular(orcamento)}");

orcamento.AdicionarItem(new Item("ITEM 5", 320));
orcamento.AdicionarItem(new Item("ITEM 6", 120));

Console.WriteLine($"Orcamento com quatro itens e valor total de R${orcamento.Valor()}");

Console.WriteLine($"O custo para o imposto do tipo ICPP foi de R${icpp.Calcular(orcamento)}");
Console.WriteLine($"O custo para o imposto do tipo ICPP foi de R${ikcv.Calcular(orcamento)}");

Console.ReadLine();
