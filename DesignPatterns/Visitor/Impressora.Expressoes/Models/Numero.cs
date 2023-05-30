using Impressora.Expressoes.Interfaces;
using Impressora.Expressoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impressora.Expressoes.Models
{
    internal class Numero : IExpressao
    {
        private int _numero;

        public Numero(int numero)
        {
            _numero = numero;
        }

        public double Avalia()
        {
            return _numero;
        }
        public IExpressao ExpressaoDireita()
        {
            throw new Exception();
        }

        public IExpressao ExpressaoEsquerda()
        {
            throw new Exception();
        }

        public void Imprime(ImpressoraVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}
