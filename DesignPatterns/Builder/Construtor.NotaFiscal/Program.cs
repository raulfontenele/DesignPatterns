using Construtor.NotaFiscal.Domain;

NotaFiscal nf = new NotaFiscalBuilder().ParaEmpresa("Caelum")
                          .ComCnpj("123.456.789/0001-10")
                          .ComItem(new Item("item 1", 100.0))
                          .ComItem(new Item("item 2", 200.0))
                          .ComItem(new Item("item 3", 300.0))
                          .ComObservacoes("entregar nf pessoalmente")
                          .NaDataAtual()
                          .Constroi();

Console.WriteLine($"O valor total da nota fiscal é de R$ {nf.ValorBruto}");
Console.WriteLine($"O valor total de imposto da nota fiscal é de R$ {nf.Impostos}");

Console.ReadLine();

