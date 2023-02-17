using Fabrica.Medidores.Models;
using Fabrica.Medidores.Interfaces;


Factory factory = new Factory();
IMeter meter = factory.Criar();

//Teste a ser executado do medidor cronos
((IMeter)meter).EscreverEnergia("Ativo", "Direto", "T1", 12345678);
((IMeter)meter).LerEnergia("Ativo", "Direto", "T1");
((IMeter)meter).LerDemanda("Reativo", "Direto", "T1");


((Cronos)meter).ObterCusto();


Console.ReadLine();