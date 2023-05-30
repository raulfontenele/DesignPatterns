using Impressora.Expressoes.Interfaces;
using Impressora.Expressoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impressora.Expressoes.Models
{
    internal class Multiplicacao : IExpressao
    {
        private IExpressao _esquerda;
        private IExpressao _direita;

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public double Avalia()
        {
            return _esquerda.Avalia() * _direita.Avalia();
        }
        public IExpressao ExpressaoDireita()
        {
            return _direita;
        }

        public IExpressao ExpressaoEsquerda()
        {
            return _esquerda;
        }

        public void Imprime(ImpressoraVisitor impressora)
        {
            impressora.ImprimeMultiplicacao(this);
        }
    }
}
