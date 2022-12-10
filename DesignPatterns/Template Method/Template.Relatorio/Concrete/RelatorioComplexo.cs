using System;
using Template.Relatorio.Interfaces;

namespace Template.Relatorio.Concrete
{
    public class RelatorioComplexo : TemplateRelatorio
    {
        public RelatorioComplexo(IBanco banco) : base(banco)
        {
        }

        protected override void ImprimirCabecalho()
        {
            Console.WriteLine("//=================================================================//");
            Console.WriteLine("                       RELATÓRIO COMPLEXO                            ");
            Console.WriteLine("//=================================================================// \n");
            Console.WriteLine($"NOME DO BANCO :: {_banco.Nome}");
            Console.WriteLine($"ENDEREÇO DO BANCO :: {_banco.Enderenco}");
            Console.WriteLine($"TELEFONE DO BANCO :: {_banco.Telefone} \n");
            Console.WriteLine("//-----------------------------------------------------------------//\n");
        }

        protected override void ImprimirCorpo()
        {
            foreach (Conta conta in _banco.Contas)
            {
                Console.WriteLine($"O {conta.NomeTitular}, dententor da conta de nº {conta.Numero}, localizada na agência {conta.Agencia}, possui saldo de R${conta.Saldo}");
            }
            Console.WriteLine("\n//-----------------------------------------------------------------//\n");
        }

        protected override void ImprimirRodape()
        {
            Console.WriteLine($"E-MAIL DO BANCO :: {_banco.Email}");
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("//=================================================================//");
        }
    }
}
