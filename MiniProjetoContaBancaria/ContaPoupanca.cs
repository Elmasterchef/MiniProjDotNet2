
public class ContaPoupanca : Conta
{
    public ContaPoupanca(string titular, decimal saldoInicial)
        : base(titular, saldoInicial)
    {
    }

    public ContaPoupanca(string titular)
        : base(titular)
    {
    }

    public void AplicarRendimentoMensal()
    {
        decimal rendimento = Saldo * 0.01m;
    Saldo = Saldo + rendimento;

    Console.WriteLine($"Rendimento aplicado: R$ {rendimento:F2}");
    }
}
