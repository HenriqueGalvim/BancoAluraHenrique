/*-Criar Conta,
  - Depositar,
  - Sacar,
  - Transferir,
  - Listar Contas,
  - Listar Contas Com saldo maior do que 1000;
-Mostrar Resultado do Relatório TotalizadorDeContas;
-Mostrar Resultado do Relatório TotalizadorDeTributos;*/

using BancoAluraHenrique.Models;
List<Conta> listaDeContas = new List<Conta>();
try
{
    ContaCorrente conta1 = new("Henrique", 100);
    ContaCorrente conta2 = new("Rafael", 50);
    ContaPoupanca conta3 = new("Ivanilce", 0);
    ContaInvestimento conta4 = new("Lucas", 0);
    SeguroDeVida conta5 = new("Lucas", 50);

    TotalizadorDeContas totalContas = new(listaDeContas);
    totalContas.AdicionarNaLista(conta1);
    totalContas.AdicionarNaLista(conta2);
    totalContas.AdicionarNaLista(conta3);
    totalContas.AdicionarNaLista(conta4);
    totalContas.AdicionarNaLista(conta5);
    conta1.Depositar(50);
    conta2.Sacar(25);
    conta1.Transferir(conta3, 50);


    Console.WriteLine($"Saldo total das contas:R${totalContas.SaldoTotal}");
    ListarContasSaldoMaior1000();
}
catch (Exception ex)
{
    Console.WriteLine("Erro: ", ex);
}

void ListarContasSaldoMaior1000()
{
    var query = listaDeContas.Where(conta => conta.Saldo > 1000);
    foreach (var item in query)
    {
        item.ExibirDetalhesConta();
    }
}