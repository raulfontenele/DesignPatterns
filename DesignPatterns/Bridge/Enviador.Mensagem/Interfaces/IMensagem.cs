﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enviador.Mensagem.Interfaces
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }
        void Envia(string mensagem);

    }
}
