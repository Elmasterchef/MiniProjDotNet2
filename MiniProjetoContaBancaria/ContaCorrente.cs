
public class ContaCorrente : Conta
{
    public decimal Limite { get; } = 500m;

    public ContaCorrente(string titular, decimal saldoInicial)
        : base(titular, saldoInicial)
    {
    }

    public ContaCorrente(string titular)
        : base(titular)
    {
    }

    public override void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("O valor do saque deve ser positivo.");
            return;
        }

        if (valor > Saldo + Limite)
        {
            Console.WriteLine("Limite da conta excedido.");
            return;
        }

        Saldo = Saldo - valor;

        Console.WriteLine("Saque realizado com sucesso!");
    }
    
public void AplicarTarifaMensal()
{
    decimal tarifa = 10m;

    if (Saldo - tarifa < -Limite)
    {
        Console.WriteLine("Não é possível cobrar a tarifa: limite excedido.");
        return;
    }

    Saldo = Saldo - tarifa;

    Console.WriteLine("Tarifa mensal de R$ 10,00 aplicada.");
}

}
