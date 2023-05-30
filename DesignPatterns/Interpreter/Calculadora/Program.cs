using Calculadora.Interfaces;
using Calculadora.Models;


//Expressão 4*(22+3) - 10*5
IExpressao esquerda = new Multiplicacao(new Numero(4), new Soma(new Numero(22), new Numero(3)));
IExpressao direita = new Multiplicacao(new Numero(10), new Numero(5));

double resultado = new Subtracao(esquerda, direita).Avalia();

Console.WriteLine($"O valor final da expressão é {resultado}");