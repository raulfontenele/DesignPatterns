using Impressora.Expressoes.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impressora.Expressoes.Models
{
    internal class RaizQuadrada : IExpressao
    {
        private IExpressao _numero;

        public RaizQuadrada(IExpressao valor)
        {
            _numero = valor;
        }

        public double Avalia()
        {
            return Math.Sqrt((double)_numero.Avalia());

        }

        public IExpressao ExpressaoDireita()
        {
            throw new NotImplementedException();
        }

        public IExpressao ExpressaoEsquerda()
        {
            throw new NotImplementedException();
        }

        public void Imprime(ImpressoraVisitor impressora)
        {
            throw new NotImplementedException();
        }
    }
}
