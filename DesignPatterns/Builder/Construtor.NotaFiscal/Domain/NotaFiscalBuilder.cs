using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor.NotaFiscal.Domain
{
    class NotaFiscalBuilder
    {
        private string RazaoSocial;
        private string Cnpj;
        private double ValorTotal;
        private double Impostos;
        private DateTime DataEmissao;
        public string Observacoes { get; private set; }
        private IList<Item> TodosItens = new List<Item>();

        public NotaFiscalBuilder()
        {
            ValorTotal = 0;
            Impostos = 0;
        }
        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }
        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.DataEmissao = DateTime.Now;
            return this;
        }
        
        public NotaFiscalBuilder ComItem(Item item)
        {
            TodosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }
        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, DataEmissao, ValorTotal, Impostos, TodosItens, Observacoes);
        }
    }
}
