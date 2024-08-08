namespace BancoAluraHenrique.Models;

internal class ContaInvestimento : Conta
{
    public ContaInvestimento(string titular, double saldo) : base(titular, saldo)
    {
        Guid meuGuid = Guid.NewGuid();
        string guid = meuGuid.ToString().Substring(0, 4);
        base.Numero = guid;
        base.Tipo = "Investimento";
    }
    public override double CalculoTributo()
    {
        double tributo = Saldo * 2;
        return tributo / 100;
    }
}
