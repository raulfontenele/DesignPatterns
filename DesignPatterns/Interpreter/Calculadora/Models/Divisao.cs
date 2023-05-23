using Calculadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    internal class Divisao : IExpressao
    {
        private IExpressao _esquerda;
        private IExpressao _direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public double Avalia()
        {
            return _esquerda.Avalia() / _direita.Avalia();
        }
    }
}
