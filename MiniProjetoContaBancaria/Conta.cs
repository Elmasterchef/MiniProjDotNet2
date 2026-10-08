
public class Conta
{
    private static int totalContas = 0;
    public string Titular { get; }
    public decimal Saldo { get; protected set; }

    public Conta(string titular, decimal saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;

        totalContas++;
    }

    public Conta(string titular)
    {
        Titular = titular;
        Saldo = 0m;

        totalContas++;
    }
    public void Depositar(decimal valor){
    if(valor<=0){
        Console.WriteLine("O valor do depósito deve ser positivo");
        return;
    }
    Saldo += valor;
    Console.WriteLine("Depósito realizado com sucesso!");
}
    public virtual void Sacar(decimal valor){
    if(valor<=0){
        Console.WriteLine("O valor do saque deve ser positivo");
        return;
    }
    
    if(Saldo<valor){
        Console.WriteLine("Saldo insuficiente");
        return;
    }
    Saldo -= valor;
    Console.WriteLine("Saque realizado com sucesso!");
}

public virtual void ExibirExtrato()
{
    Console.WriteLine("===== EXTRATO BANCÁRIO =====");
    Console.WriteLine($"Titular: {Titular}");
    Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
    Console.WriteLine("============================");
}
public static int ConsultarTotalContas()
{
    return totalContas;
}
}
