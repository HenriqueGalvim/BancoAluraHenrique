namespace BancoAluraHenrique.Models;

internal class TotalizadorDeTributos
{
    public TotalizadorDeTributos(List<Conta> listaDeContasParaTributo)
    {
        ListaDeContasParaTributo = new(listaDeContasParaTributo);
    }

    public List<Conta> ListaDeContasParaTributo
    {
        get
        {
            return ListaDeContasParaTributo;
        }
        set
        {
            int controle = ListaDeContasParaTributo.Count(conta => conta.Tipo == "Corrente" || conta.Tipo == "Poupança");

            if (controle >= 0)
            {
                Console.WriteLine("Erro, verifique a lista passada, só é aceito contas do tipo Investimento e Seguro de Vida");
            }
            else
            {
                ListaDeContasParaTributo = value;
            }
        }
    }
    public double AcumuloImpostoTotal
    {
        get
        {
            double acumulador = 0;
            return acumulador += ListaDeContasParaTributo.Sum(conta => conta.CalculoTributo());
        }
    }

    public void AdicionarNaListaDeContas(Conta conta)
    {
        ListaDeContasParaTributo.Add(conta);
    }

    public void ExibirTotalAcumulado()
    {
        Console.WriteLine($"######### Exibindo Total Acumulado de Imposto");
        Console.WriteLine($"Total Acumulado: {AcumuloImpostoTotal}");
        Console.WriteLine($"Total de contas de Investimento: {ListaDeContasParaTributo.Count(conta => conta.Tipo.Equals("Investimento"))}");
        Console.WriteLine($"Total de contas de Seguro de vida: {ListaDeContasParaTributo.Count(conta => conta.Tipo.Equals("Seguro"))}");
    }
}
