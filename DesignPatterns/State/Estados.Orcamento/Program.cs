using Estados.Orcamento.Concrete;
using Estados.Orcamento.Concrete.States;
using Estados.Orcamento.Interfaces;

IOrcamento orcamento = new Orcamento(10000);

Console.WriteLine("ORÇAMENTO INICIALMENTE EM ANDAMENTO \n \n");

Console.WriteLine($"O valor inicial do orcamento é {orcamento.Valor()}");
Console.WriteLine($"A primeira tentativa de desconto, resultou em desconto de R$ {orcamento.AplicarDesconto()} e um novo valor de R$ {orcamento.Valor()}");
Console.WriteLine($"A segunda tentativa de desconto, resultou em desconto de R$ {orcamento.AplicarDesconto()} e um novo valor de R$ {orcamento.Valor()}");

Console.WriteLine("\n \n TENTATIVA DE MUDAR O ESTADO DO ORCAMENTO PARA FINALIADO \n \n");
(TiposEstados estado, bool confirmacao) = orcamento.Finalizar();
Console.WriteLine($"A tentativa resultatou no estado {estado.ToString()}");

Console.WriteLine("\n \n TENTATIVA DE MUDAR O ESTADO DO ORCAMENTO PARA APROVADO \n \n");
(estado, confirmacao) = orcamento.Aprovar();
Console.WriteLine($"A tentativa resultatou no estado {estado.ToString()}");

Console.WriteLine($"O valor atual do orcamento é {orcamento.Valor()}");
Console.WriteLine($"A primeira tentativa de desconto, resultou em desconto de R$ {orcamento.AplicarDesconto()} e um novo valor de R$ {orcamento.Valor()}");
Console.WriteLine($"A segunda tentativa de desconto, resultou em desconto de R$ {orcamento.AplicarDesconto()} e um novo valor de R$ {orcamento.Valor()}");

Console.WriteLine("\n \n TENTATIVA DE MUDAR O ESTADO DO ORCAMENTO PARA REPROVADO \n \n");
(estado, confirmacao) = orcamento.Reprovar();
Console.WriteLine($"A tentativa resultatou no estado {estado.ToString()}");

Console.WriteLine("\n \n TENTATIVA DE MUDAR O ESTADO DO ORCAMENTO PARA FINALIZADO \n \n");
(estado, confirmacao) = orcamento.Finalizar();
Console.WriteLine($"A tentativa resultatou no estado {estado.ToString()}");

Console.WriteLine($"O valor atual do orcamento é {orcamento.Valor()}");
Console.WriteLine($"A primeira tentativa de desconto, resultou em desconto de R$ {orcamento.AplicarDesconto()} e um novo valor de R$ {orcamento.Valor()}");
Console.WriteLine($"A segunda tentativa de desconto, resultou em desconto de R$ {orcamento.AplicarDesconto()} e um novo valor de R$ {orcamento.Valor()}");




