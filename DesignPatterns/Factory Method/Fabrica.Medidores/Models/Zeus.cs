using Fabrica.Medidores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica.Medidores.Models
{
    public class Zeus :IMeter
    {
        private const string nome = "Zeus NG";
        private double _constanteMultiplicacao;

        public Zeus(double constanteMultiplicacao)
        {
            this._constanteMultiplicacao = constanteMultiplicacao;
        }

        public void LerEnergia(string tipoAtivo, string tipoReativo, string tarifa)
        {
            Console.WriteLine($"Realizada leitura no medidor {nome} da energia do tipo {tipoAtivo}-{tipoReativo}-{tarifa} ");
        }
        public void LerDemanda(string tipoAtivo, string tipoReativo, string tarifa)
        {
            Console.WriteLine($"Realizada leitura no medidor {nome} da demanda do tipo {tipoAtivo}-{tipoReativo}-{tarifa} ");
        }
        public void EscreverEnergia(string tipoAtivo, string tipoReativo, string tarifa, double valor)
        {
            Console.WriteLine($"Realizada escrita da energia do tipo {tipoAtivo}-{tipoReativo}-{tarifa} no medidor {nome} com valor de {valor * _constanteMultiplicacao}");
        }
        public void ObterCostanteMultiplicacao()
        {
            Console.WriteLine($"O valor da constante de multiplicação para o medidor do tipo {nome} é de {_constanteMultiplicacao}");
        }
    }
}
