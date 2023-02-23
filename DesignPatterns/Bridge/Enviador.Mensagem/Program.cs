using Enviador.Mensagem.Interfaces;
using Enviador.Mensagem.Models.Enviador;
using Enviador.Mensagem.Models.Mensagem;


IMensagem mensagem = new MensagemAdministrativo();
IEnviador enviador = new EnviarPorEmail();
mensagem.Enviador = enviador;
mensagem.Envia("Mensagem de adm por e-mail");

mensagem = new MensagemAdministrativo();
enviador = new EnviarPorWhatsapp();
mensagem.Enviador = enviador;
mensagem.Envia("Mensagem de adm por whatsapp");

mensagem = new MensagemCliente();
enviador = new EnviarPorWhatsapp();
mensagem.Enviador = enviador;
mensagem.Envia("Mensagem de cliente por whatsapp");

mensagem = new MensagemCliente();
enviador = new EnviarPorEmail();
mensagem.Enviador = enviador;
mensagem.Envia("Mensagem de cliente por e-mail");


Console.ReadLine();


