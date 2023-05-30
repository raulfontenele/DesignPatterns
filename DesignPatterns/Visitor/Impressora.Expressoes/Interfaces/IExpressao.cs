using Impressora.Expressoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impressora.Expressoes.Interfaces
{
    internal interface IExpressao
    {
        public double Avalia();
        public void Imprime(ImpressoraVisitor impressora);
        public IExpressao ExpressaoEsquerda();
        public IExpressao ExpressaoDireita();
    }
}
