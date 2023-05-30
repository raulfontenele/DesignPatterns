using Impressora.Expressoes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impressora.Expressoes.Models
{
    internal class ImpressoraVisitor
    {
        public void ImprimeSoma(IExpressao expressao)
        {
            ImprimeExpressao(expressao, "+");
        }
        public void ImprimeSubtracao(IExpressao expressao)
        {
            ImprimeExpressao(expressao, "-");
        }
        public void ImprimeMultiplicacao(IExpressao expressao)
        {
            ImprimeExpressao(expressao, "*");
        }
        public void ImprimeDivisao(IExpressao expressao)
        {
            ImprimeExpressao(expressao, "/");
        }
        public void ImprimeNumero(IExpressao expressao)
        {
            Console.Write(expressao.Avalia());
        }
        private void ImprimeExpressao(IExpressao expressao, string simbolo)
        {
            Console.Write("( ");
            expressao.ExpressaoEsquerda().Imprime(this);
            Console.Write($" {simbolo} ");
            expressao.ExpressaoDireita().Imprime(this);
            Console.Write(" )");
        }
    }
}
