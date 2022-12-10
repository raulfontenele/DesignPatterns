using Template.Relatorio.Concrete;
using Template.Relatorio.Interfaces;


IBanco banco = new Banco("BANCO 1", "ENDEREÇO 1", "EMAIL 1", 123456789);

IRelatorio relatorioSimples = new RelatorioSimples(banco);
IRelatorio relatorioComplexo = new RelatorioComplexo(banco);

Console.WriteLine("Relatórios do banco sem a inclusão de contas");

Console.WriteLine("\n\n\n");

relatorioSimples.ImprimirRelatorio();

Console.WriteLine("\n\n\n");

relatorioComplexo.ImprimirRelatorio();

Console.WriteLine("\n\n\n");

//ADICIONANDO NOVAS CONTAS PARA NOVA VALIDAÇÃO DOS RELATÓRIOS

Conta conta = new ("NOME 1", 1, 1, 10);

banco.AdicionarContas(conta);

conta = new ("NOME 2", 2, 2, 20);

banco.AdicionarContas(conta);

conta = new ("NOME 3", 3, 3, 30);

banco.AdicionarContas(conta);

Console.WriteLine("Relatórios do banco com a inclusão de 3 novas contas");

relatorioSimples = new RelatorioSimples(banco);
relatorioComplexo = new RelatorioComplexo(banco);

Console.WriteLine("\n\n\n");

relatorioSimples.ImprimirRelatorio();

Console.WriteLine("\n\n\n");

relatorioComplexo.ImprimirRelatorio();

