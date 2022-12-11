using Calculadora.Investimentos.Concrete;
using Calculadora.Investimentos.Interfaces;
using Calculadora.Investimentos.Concrete.Tipos.Investimentos;

decimal investimentoInicial = 1000;

IConta conta = new Conta(investimentoInicial);

Console.WriteLine($"Para uma investimento inicial R${investimentoInicial}, utilizando uma estratégia conservadora, o retorno do investimento foi de R${RealizadorInvestimentos.RealizarInvestimento(conta, new Conservador())}");
Console.WriteLine($"Para uma investimento inicial R${investimentoInicial}, utilizando uma estratégia moderada, o retorno do investimento foi de R${RealizadorInvestimentos.RealizarInvestimento(conta, new Moderado())}");
Console.WriteLine($"Para uma investimento inicial R${investimentoInicial}, utilizando uma estratégia arrojada, o retorno do investimento foi de R${RealizadorInvestimentos.RealizarInvestimento(conta, new Arrojado())}");
Console.WriteLine("\n\n");

investimentoInicial = 5000;

conta = new Conta(investimentoInicial);

Console.WriteLine($"Para uma investimento inicial R${investimentoInicial}, utilizando uma estratégia conservadora, o retorno do investimento foi de R${RealizadorInvestimentos.RealizarInvestimento(conta, new Conservador())}");
Console.WriteLine($"Para uma investimento inicial R${investimentoInicial}, utilizando uma estratégia moderada, o retorno do investimento foi de R${RealizadorInvestimentos.RealizarInvestimento(conta, new Moderado())}");
Console.WriteLine($"Para uma investimento inicial R${investimentoInicial}, utilizando uma estratégia arrojada, o retorno do investimento foi de R${RealizadorInvestimentos.RealizarInvestimento(conta, new Arrojado())}");
Console.WriteLine("\n\n");

investimentoInicial = 0;

conta = new Conta(investimentoInicial);

Console.WriteLine($"Para uma investimento inicial R${investimentoInicial}, utilizando uma estratégia conservadora, o retorno do investimento foi de R${RealizadorInvestimentos.RealizarInvestimento(conta, new Conservador())}");
Console.WriteLine($"Para uma investimento inicial R${investimentoInicial}, utilizando uma estratégia moderada, o retorno do investimento foi de R${RealizadorInvestimentos.RealizarInvestimento(conta, new Moderado())}");
Console.WriteLine($"Para uma investimento inicial R${investimentoInicial}, utilizando uma estratégia arrojada, o retorno do investimento foi de R${RealizadorInvestimentos.RealizarInvestimento(conta, new Arrojado())}");
