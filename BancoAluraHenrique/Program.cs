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
    ContaInvestimento conta4 = new("Lucas", 1000);
    SeguroDeVida conta5 = new("Lucas", 50);
    listaDeContas.Add(conta1);
    listaDeContas.Add(conta2);
    listaDeContas.Add(conta3);
    listaDeContas.Add(conta4);
    listaDeContas.Add(conta5);

    TotalizadorDeContas totalContas = new(listaDeContas);
    TotalizadorDeTributos totalContasTributos = new(listaDeContas);
   
    conta1.Depositar(50);
    conta2.Sacar(25);
    conta1.Transferir(conta3, 50);


    Console.WriteLine($"Saldo total das contas:R${totalContas.SaldoTotal}\n\n");
    totalContas.ListarContas();
    totalContas.ListarContasSaldoMaior1000();

    totalContas.ExibirRelatorio();
    totalContasTributos.ExibirTotalAcumulado();
}
catch (Exception ex)
{
    Console.WriteLine("Erro: ", ex);
}

