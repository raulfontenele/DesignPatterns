using Composicao.Impostos.Concrete.Impostos;
using Template.Imposto.Concrete;
using Template.Imposto.Concrete.Impostos;
using Template.Imposto.Interfaces;

ICPP icpp = new();
IKCV ikcv = new(icpp);
IHIT ihit = new(ikcv);
ImpostoRenda renda = new(ihit);

IOrcamento orcamento = new Orcamento();

orcamento.AdicionarItem(new Item("ITEM 1", 300));
orcamento.AdicionarItem(new Item("ITEM 2", 700));

Console.WriteLine($"Orcamento com dois itens e valor total de R${orcamento.Valor()}");

Console.WriteLine($"O custo para a composição dos impostos ICPP, IHIT e IKCV foi de R${renda.Calcular(orcamento)}");

orcamento.AdicionarItem(new Item("ITEM 3", 900));
orcamento.AdicionarItem(new Item("ITEM 4", 100));

Console.WriteLine($"Orcamento com quatro itens e valor total de R${orcamento.Valor()}");

Console.WriteLine($"O custo para a composição dos impostos ICPP, IHIT e IKCV foi de R${renda.Calcular(orcamento)}");