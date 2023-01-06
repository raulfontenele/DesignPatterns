using Acoes.Construtor.NotaFiscal.Domain;
using Acoes.Construtor.NotaFiscal.Interface;


List<IAcoesNotaFiscal> actions = new List<IAcoesNotaFiscal>()
{
    new SalvarDados(),
    new NotificarResponsaveis(),
    new Multiplicador(10.3)
};


NotaFiscalBuilder nfbuilder = new NotaFiscalBuilder(actions).ParaEmpresa("Caelum")
                          .ComCnpj("123.456.789/0001-10")
                          .ComItem(new Item("item 1", 100.0))
                          .ComItem(new Item("item 2", 200.0))
                          .ComItem(new Item("item 3", 300.0))
                          .ComObservacoes("entregar nf pessoalmente")
                          .NaDataAtual();



NotaFiscal nf =  nfbuilder.Constroi();

Console.WriteLine($"O valor total da nota fiscal é de R$ {nf.ValorBruto}");
Console.WriteLine($"O valor total de imposto da nota fiscal é de R$ {nf.Impostos}");

Console.ReadLine();