using Acoes.Construtor.NotaFiscal.Interface;

namespace Acoes.Construtor.NotaFiscal.Domain
{
    class NotaFiscalBuilder
    {
        private string RazaoSocial;
        private string Cnpj;
        private double ValorTotal;
        private double Impostos;
        private DateTime DataEmissao;
        public string Observacoes { get; private set; }
        private List<Item> TodosItens = new List<Item>();
        private List<IAcoesNotaFiscal> ListaAcoes;

        public NotaFiscalBuilder(List<IAcoesNotaFiscal> listaAcoes)
        {
            ValorTotal = 0;
            Impostos = 0;
            ListaAcoes = listaAcoes;
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
            NotaFiscal nf =  new NotaFiscal(RazaoSocial, Cnpj, DataEmissao, ValorTotal, Impostos, TodosItens, Observacoes);

            foreach(IAcoesNotaFiscal acao in ListaAcoes) 
            {
                acao.Executar(nf);
            }

            return nf;
        }
    }
}
