//Expressão 4*(22+3) - 10*5
using Impressora.Expressoes.Interfaces;
using Impressora.Expressoes.Models;

IExpressao esquerda = new Multiplicacao(new Numero(4), new Soma(new Numero(22), new Numero(3)));
IExpressao direita = new Multiplicacao(new Numero(10), new Numero(5));



IExpressao subtracao = new Subtracao(esquerda, direita);
double resultado = subtracao.Avalia();
Console.WriteLine($"O valor final da expressão é {resultado}");

ImpressoraVisitor visitor = new ImpressoraVisitor();


subtracao.Imprime(visitor);
//visitor.ImprimeSubtracao(subtracao);

