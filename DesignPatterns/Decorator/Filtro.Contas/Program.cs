using Filtros.Contas.Abstract;
using Filtros.Contas.Concrete;
using Filtros.Contas.Concrete.Tipos.Filtros;

Filtro filtroValor = new FiltroSaldo();
Filtro filtroData = new FiltroDataAbertura(filtroValor);

Conta conta1 = new("Conta 1", 50, new DateTime(2023, 10, 10));
Conta conta2 = new("Conta 2", 200, new DateTime(2023, 10, 10));
Conta conta3 = new("Conta 3", 600, new DateTime(2023, 01, 10));
Conta conta4 = new("Conta 4", 400000, new DateTime(2023, 02, 11));
Conta conta5 = new("Conta 5", 500001, new DateTime(2023, 02, 11));

IList<Conta> contaList = new List<Conta>() { conta1, conta2, conta3, conta4, conta5 };

var returnoContasFiltro = filtroData.Filtra(contaList);

Console.WriteLine("Lista de contas dentro dos critérios: \n");
foreach (Conta conta in returnoContasFiltro)
    Console.WriteLine($"Nome: {conta.Nome} || Saldo: {conta.Saldo} || Data de abertura: {conta.DataAbertura.ToShortDateString()}");
