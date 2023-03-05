using Gerador.XML.Model;

Cliente cliente = new Cliente("Nome1", "85999999999", "123456789");

string xml = new GeradorXml().Gerar(cliente);

Console.WriteLine(xml);

Console.ReadLine();