using Calculadora.Imposto.Concrete;
using Calculadora.Imposto.Concrete.Impostos;
using Calculadora.Imposto.Interfaces;


CalculadoraImposto calculadoraImposto = new();
IOrcamento orcamento;


Console.WriteLine("Valores de imposto para um orçamento de R$ 1.000,00");

orcamento = new Orcamento(1000);

Console.WriteLine("ICMS: " +
    $"{calculadoraImposto.Calcular(orcamento, new ICMS())}");
Console.WriteLine("ISS: " +
    $"{calculadoraImposto.Calcular(orcamento, new ISS())}");
Console.WriteLine("ICMS: " +
    $"{calculadoraImposto.Calcular(orcamento, new ICCC())}");


Console.WriteLine("Valores de imposto para um orçamento de R$ 2.000,00");

orcamento = new Orcamento(2000);

Console.WriteLine("ICMS: " +
    $"{calculadoraImposto.Calcular(orcamento, new ICMS())}");
Console.WriteLine("ISS: " +
    $"{calculadoraImposto.Calcular(orcamento, new ISS())}");
Console.WriteLine("ICMS: " +
    $"{calculadoraImposto.Calcular(orcamento, new ICCC())}");
