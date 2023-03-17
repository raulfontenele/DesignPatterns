using Fila.Comandos.Models;

Pedido pedido1 = new Pedido("Mauricio", 150.0);
Pedido pedido2 = new Pedido("Marcelo", 250.0);

FilaTrabalho fila = new FilaTrabalho();

fila.Adiciona(new PagaPedido(pedido1));
fila.Adiciona(new PagaPedido(pedido2));
fila.Adiciona(new FinalizaPedido(pedido1));

fila.Processa();

Console.ReadLine();
