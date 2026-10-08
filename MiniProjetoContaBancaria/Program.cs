
Conta correnteLimite = new ContaCorrente("Rafael", 200m);
ContaCorrente correnteTarifa = new ContaCorrente("Theo", 1000m);
ContaPoupanca poupanca = new ContaPoupanca("Danielle", 1000m);

Console.WriteLine("=== TESTE 1: POLIMORFISMO E LIMITE ===");

correnteLimite.Depositar(-50m);
Console.WriteLine($"Saldo após depósito inválido: R$ {correnteLimite.Saldo:F2}");

correnteLimite.Sacar(700m);
Console.WriteLine($"Saldo após saque: R$ {correnteLimite.Saldo:F2}");

correnteLimite.Sacar(1m);
correnteLimite.ExibirExtrato();

Console.WriteLine();
Console.WriteLine("=== TESTE 2: TARIFA MENSAL ===");

correnteTarifa.AplicarTarifaMensal();
correnteTarifa.ExibirExtrato();

Console.WriteLine();
Console.WriteLine("=== TESTE 3: POUPANCA ===");

poupanca.AplicarRendimentoMensal();
poupanca.ExibirExtrato();

Console.WriteLine();
Console.WriteLine("=== TESTE 4: CONTADOR ===");

Console.WriteLine(
    $"Total de contas criadas: {Conta.ConsultarTotalContas()}");
