﻿using Acoes.Construtor.NotaFiscal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoes.Construtor.NotaFiscal.Domain
{
    public class NotaFiscal : INotaFiscal
    {
        private String RazaoSocial { get;  set; }
        private String Cnpj { get;  set; }
        private DateTime DataDeEmissao { get;  set; }
        public double ValorBruto { get;  set; }
        public double Impostos { get;  set; }
        public IList<Item> Itens { get; private set; }
        public String Observacoes { get; private set; }

        public NotaFiscal(String razaoSocial, String cnpj, DateTime dataDeEmissao,
                      double valorBruto, double impostos, IList<Item> itens,
                      String observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataDeEmissao = dataDeEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }
    }
}
