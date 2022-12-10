using Template.Relatorio.Interfaces;

namespace Template.Relatorio.Concrete
{
    public class RelatorioSimples : TemplateRelatorio
    {
        public RelatorioSimples(IBanco banco) : base(banco)
        {
        }

        protected override void ImprimirCabecalho()
        {
            Console.WriteLine("//=================================================================//");
            Console.WriteLine("                       RELATÓRIO SIMPLES                             ");
            Console.WriteLine("//=================================================================// \n");
            Console.WriteLine($"NOME DO BANCO :: {_banco.Nome} \n");
            Console.WriteLine("//-----------------------------------------------------------------// \n");
        }

        protected override void ImprimirCorpo()
        {
            foreach(Conta conta in _banco.Contas)
            {
                Console.WriteLine($"O {conta.NomeTitular} possui saldo de R${conta.Saldo}");
            }
            Console.WriteLine("\n//-----------------------------------------------------------------//\n");
        }

        protected override void ImprimirRodape()
        {
            Console.WriteLine($"TELEFONE DO BANCO :: {_banco.Telefone}");
            Console.WriteLine("//=================================================================//");
        }
    }
}
