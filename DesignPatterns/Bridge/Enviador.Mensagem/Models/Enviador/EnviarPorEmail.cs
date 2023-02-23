using Enviador.Mensagem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enviador.Mensagem.Models.Enviador
{
    public class EnviarPorEmail : IEnviador
    {
        public void Envia(string mensagem)
        {
            Console.WriteLine($"Enviando a mensagem por e-mail : '{mensagem}'");
        }
    }
}
