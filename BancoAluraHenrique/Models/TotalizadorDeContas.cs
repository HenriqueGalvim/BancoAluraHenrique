using System.Linq.Expressions;

namespace BancoAluraHenrique.Models;

internal class TotalizadorDeContas
{
    public TotalizadorDeContas(List<Conta> listaDeContas)
    {
        ListaDeContas = new(listaDeContas);
    }
    private List<Conta> ListaDeContas { get; set; }

    public double SaldoTotal
    {
        get
        {
            double total = ListaDeContas.Sum(item => item.Saldo);
            return total;
        }
    }

    public void ExibirRelatorio()
    {
        Console.WriteLine("\n------------- Relatorio Total de Contas -------------\n");
        Console.WriteLine($"Total de contas: {ListaDeContas.Count()}");
        Console.WriteLine($"Total de saldo acumulado: R${SaldoTotal}");
        Console.WriteLine("");
    }
    public void AdicionarNaLista(Conta conta)
    {
        ListaDeContas.Add(conta);
    }

    public void ListarContas()
    {
        Console.WriteLine("-------------- Listando Contas --------------");
        foreach (var conta in ListaDeContas)
        {
            conta.ExibirDetalhesConta();
        }
    }

    public void ListarContasSaldoMaior1000()
    {
        Console.WriteLine("-------------- Listando Contas com saldo maior que 1000 --------------");
        var queryConta = ListaDeContas.Where(conta => conta.Saldo > 1000);
        if (queryConta.Count() > 0)
        {
            foreach (var conta in queryConta)
            {
                conta.ExibirDetalhesConta();
            }
        }
        else
        {
            Console.WriteLine("Nenhuma conta com saldo maior que 1000 existe cadastrada");
        }
    }
}
