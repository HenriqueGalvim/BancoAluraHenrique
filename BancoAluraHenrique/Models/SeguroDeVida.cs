using System;

namespace BancoAluraHenrique.Models;

internal class SeguroDeVida:Conta
{
    public SeguroDeVida(string titular, double saldo) : base(titular, saldo)
    {
        base.Tipo = "Seguro";
    }
    public override double CalculoTributo()
    {
        return 50;
    }
}
