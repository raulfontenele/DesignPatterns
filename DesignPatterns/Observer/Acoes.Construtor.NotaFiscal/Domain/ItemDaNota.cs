﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoes.Construtor.NotaFiscal.Domain
{
    public class Item
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
