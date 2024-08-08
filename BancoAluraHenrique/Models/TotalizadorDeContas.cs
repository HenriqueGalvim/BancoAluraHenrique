using System.Linq.Expressions;

namespace BancoAluraHenrique.Models;

internal class TotalizadorDeContas
{
    public TotalizadorDeContas(List<Conta> listaDeContas)
    {
        ListaDeContas = new(listaDeContas);
    }
    public List<Conta> ListaDeContas { get; set; }

    public double SaldoTotal
    {
        get
        {
            double total = ListaDeContas.Sum(item => item.Saldo);
            return total;
        }
    }

    public void AdicionarNaLista(Conta conta)
    {
        ListaDeContas.Add(conta);
    }

}
