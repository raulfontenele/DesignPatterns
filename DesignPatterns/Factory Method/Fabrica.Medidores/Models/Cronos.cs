using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrica.Medidores.Interfaces;

namespace Fabrica.Medidores.Models
{
    public class Cronos:IMeter
    {
        private double _custo;

        private const string nome = "Cronos NG";

        public Cronos(double custo)
        {
            _custo = custo;
        }

        public void LerEnergia(string tipoAtivo, string tipoReativo, string tarifa)
        {
            Console.WriteLine($"Realizada leitura da energia do tipo {tipoAtivo}-{tipoReativo}-{tarifa} no medidor {nome}");
        }
        public void LerDemanda(string tipoAtivo, string tipoReativo, string tarifa)
        {
            Console.WriteLine($"Realizada leitura da demanda do tipo {tipoAtivo}-{tipoReativo}-{tarifa} no medidor {nome}");
        }
        public void EscreverEnergia(string tipoAtivo, string tipoReativo, string tarifa, double valor)
        {
            Console.WriteLine($"Realizada escrita da energia do tipo {tipoAtivo}-{tipoReativo}-{tarifa} no medidor {nome} com valor de {valor}");
        }
        public void ObterCusto()
        {
            Console.WriteLine($"O valor do custo para o medidor do tipo {nome} é de {_custo}");
        }
    }
}
