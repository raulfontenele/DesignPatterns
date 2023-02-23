using Enviador.Mensagem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enviador.Mensagem.Models.Mensagem
{
    public class MensagemAdministrativo : IMensagem
    {
        public IEnviador Enviador { get; set; }

        public void Envia(string mensagem)
        {
            Enviador.Envia($"Enviando mensagem pro administrativo :: {mensagem}");
        }

    }
}
