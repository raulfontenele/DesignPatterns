﻿using Calculadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Models
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
    }
}
