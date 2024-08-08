namespace BancoAluraHenrique.Models;

internal class ContaCorrente : Conta
{
    public ContaCorrente(string titular, double saldo) : base(titular, saldo)
    {
        Guid meuGuid = Guid.NewGuid();
        string guid = meuGuid.ToString().Substring(0, 4);
        base.Numero = guid;
        base.Tipo = "Corrente";
    }
}
