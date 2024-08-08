namespace BancoAluraHenrique.Models;

internal class TotalizadorDeTributos
{
    public TotalizadorDeTributos(List<Conta> ListaDeContasParaTributo)
    {
        listaDeContasParaTributo = new(ListaDeContasParaTributo);
    }
    private List<Conta> listaDeContasParaTributo { get; set; }
    public List<Conta> ListaDeContasParaTributo
    {
        get
        {
            return listaDeContasParaTributo;
        }
        set
        {
            int controle = listaDeContasParaTributo.Count(conta => conta.Tipo == "Corrente" || conta.Tipo == "Poupança");

            if (controle >= 0)
            {
                Console.WriteLine("Erro, verifique a lista passada, só é aceito contas do tipo Investimento e Seguro de Vida");
            }
            else
            {
                listaDeContasParaTributo = value;
            }
        }
    }
    public double AcumuloImpostoTotal
    {
        get
        {
            double acumulador = 0;
            return acumulador += listaDeContasParaTributo.Sum(conta => conta.CalculoTributo());
        }
    }

    public void AdicionarNaListaDeContas(Conta conta)
    {
        listaDeContasParaTributo.Add(conta);
    }

    public void ExibirTotalAcumulado()
    {
        Console.WriteLine($"######### Exibindo Total Acumulado de Imposto #########");
        Console.WriteLine($"Total Acumulado: {AcumuloImpostoTotal}");
        Console.WriteLine($"Total de contas de Investimento: {listaDeContasParaTributo.Count(conta => conta.Tipo.Equals("Investimento"))}");
        Console.WriteLine($"Total de contas de Seguro de vida: {listaDeContasParaTributo.Count(conta => conta.Tipo.Equals("Seguro"))}\n\n");
    }
}
