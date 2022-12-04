using Estados.Conta.Bancaria.Interfaces;
using Estados.Conta.Bancaria.Concrete;
using Estados.Conta.Bancaria.Concrete.States;


IContaBancaria contaBancaria = new ContaBancaria(new ContaPositiva());
Console.WriteLine("Iniciando uma conta bancária com estado positivo");

Console.WriteLine($"Após realizar a realização de um depósito de R$ 1.000,00 a conta ficou com saldo de {contaBancaria.RealizarDeposito(1000)}");
Console.WriteLine($"Após realizar a realização de um depósito de R$ 3.000,00 a conta ficou com saldo de {contaBancaria.RealizarDeposito(3000)}");
Console.WriteLine($"Após realizar a realização de um saque de R$ 4.000,00 a conta ficou com saldo de {contaBancaria.RealizarSaque(4000)}");
Console.WriteLine($"Após realizar a realização de um saque de R$ 5.000,00 a conta ficou com saldo de {contaBancaria.RealizarSaque(5000)}");

contaBancaria = new ContaBancaria(new ContaPositiva());
Console.WriteLine("\n\n Iniciando uma conta bancária com estado positivo");

Console.WriteLine($"Após realizar a realização de um saque de R$ 1.000,00 a conta ficou com saldo de {contaBancaria.RealizarSaque(1000)}");
Console.WriteLine($"Após realizar a realização de um saque de R$ 3.000,00 a conta ficou com saldo de {contaBancaria.RealizarSaque(3000)}");
Console.WriteLine($"Após realizar a realização de um depósito de R$ 4.000,00 a conta ficou com saldo de {contaBancaria.RealizarDeposito(4000)}");
Console.WriteLine($"Após realizar a realização de um depósito de R$ 5.000,00 a conta ficou com saldo de {contaBancaria.RealizarDeposito(5000)}");

contaBancaria = new ContaBancaria(new ContaNegativa());
Console.WriteLine("\n\n Iniciando uma conta bancária com estado negativo");

Console.WriteLine($"Após realizar a realização de um depósito de R$ 1.000,00 a conta ficou com saldo de {contaBancaria.RealizarDeposito(1000)}");
Console.WriteLine($"Após realizar a realização de um depósito de R$ 3.000,00 a conta ficou com saldo de {contaBancaria.RealizarDeposito(3000)}");
Console.WriteLine($"Após realizar a realização de um saque de R$ 4.000,00 a conta ficou com saldo de {contaBancaria.RealizarSaque(4000)}");
Console.WriteLine($"Após realizar a realização de um saque de R$ 5.000,00 a conta ficou com saldo de {contaBancaria.RealizarSaque(5000)}");

contaBancaria = new ContaBancaria(new ContaNegativa());
Console.WriteLine("\n\n Iniciando uma conta bancária com estado negativo");

Console.WriteLine($"Após realizar a realização de um saque de R$ 1.000,00 a conta ficou com saldo de {contaBancaria.RealizarSaque(1000)}");
Console.WriteLine($"Após realizar a realização de um saque de R$ 3.000,00 a conta ficou com saldo de {contaBancaria.RealizarSaque(3000)}");
Console.WriteLine($"Após realizar a realização de um depósito de R$ 4.000,00 a conta ficou com saldo de {contaBancaria.RealizarDeposito(4000)}");
Console.WriteLine($"Após realizar a realização de um saque de R$ 5.000,00 a conta ficou com saldo de {contaBancaria.RealizarSaque(5000)}");