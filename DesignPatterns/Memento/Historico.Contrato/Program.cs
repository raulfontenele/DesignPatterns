using Historico.Contrato.Models;

try
{
    EstadoContrato estado;

    Contrato contrato = new Contrato("Cliente");

    HistoricoContrato historico = new HistoricoContrato();

    historico.Adicionar( new EstadoContrato(contrato.EstadoAtual()) );

    Thread.Sleep(1000);

    contrato.AvancarEstado();

    historico.Adicionar(new EstadoContrato(contrato.EstadoAtual()));

    Thread.Sleep(1000);

    contrato.AvancarEstado();

    historico.Adicionar(new EstadoContrato(contrato.EstadoAtual()));

    for(int i = 0; i < historico.NumeroEstados(); i++) 
        Console.WriteLine($"Estado no index {i} com o estado do contrato {historico.Obter(i).Contrato.AvancarEstado} modificado na data {historico.Obter(i).DataAlteracao.ToLongTimeString()}");


}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
