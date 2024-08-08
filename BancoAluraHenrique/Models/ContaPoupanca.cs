namespace BancoAluraHenrique.Models;

internal class ContaPoupanca:Conta
{
    public ContaPoupanca(string titular, double saldo) : base(titular, saldo)
    {
        Guid meuGuid = Guid.NewGuid();
        string guid = meuGuid.ToString().Substring(0, 4);
        base.Numero = guid;
        base.Tipo = "Corrente";
    }

    public override void Sacar(double valor)
    {
        base.Sacar(valor);
        Saldo -= 0.10;
        Console.WriteLine("Taxando a poupança com 0.10 centavos");
        ExibirDetalhesConta();
    }
}
