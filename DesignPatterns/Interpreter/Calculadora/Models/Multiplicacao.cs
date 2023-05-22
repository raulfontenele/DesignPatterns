using Calculadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Models
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

        public int Avalia()
        {
            return _esquerda.Avalia() * _direita.Avalia();
        }
    }
}
