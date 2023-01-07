using Cadeia.Tipos.Requisicoes.Domain;
using Cadeia.Tipos.Requisicoes.Extensions;
using Cadeia.Tipos.Requisicoes.Interfaces;

IConta conta = new Conta("Nome 1", 123456789);
Requisicao requisicaoXML = new Requisicao(Formato.XML);
Requisicao requisicaoPorcento = new Requisicao(Formato.PORCENTO);
Requisicao requisicaoCSV = new Requisicao(Formato.CSV);


Console.WriteLine($"Resposta do sistema a uma requisição do tipo XML :: {ConstrutorCadeia.RealizarRequisicao(conta, requisicaoXML)}");
Console.WriteLine($"Resposta do sistema a uma requisição do tipo CSV :: {ConstrutorCadeia.RealizarRequisicao(conta, requisicaoCSV)}");
Console.WriteLine($"Resposta do sistema a uma requisição do tipo Porcento :: {ConstrutorCadeia.RealizarRequisicao(conta, requisicaoPorcento)}");

