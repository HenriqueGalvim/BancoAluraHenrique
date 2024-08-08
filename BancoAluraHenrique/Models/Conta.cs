using System.Linq.Expressions;

namespace BancoAluraHenrique.Models;

internal class Conta
{
    public Conta(string titular, double saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }

    public string Titular { get; }
    public string Numero { get; set; }

    private double saldo { get; set; }
    public double Saldo
    {
        get
        {
            return saldo;
        }
        set
        {
            if (value < 0)
            {
                saldo = 0;
            }
            else
            {
               saldo = value;
            }
        }
    }
    private string tipo { get; set; }
    public string Tipo
    {
        get
        {
            return tipo;
        }
        set
        {
            tipo = value;
        }
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public virtual void Sacar(double valor)
    {
        if (saldo <= 0)
        {
            Console.WriteLine($"Saldo da conta {Saldo} é menor ou igual 0, impossibilitado de sacar");
        }
        else
        {
            saldo -= valor;
            Console.WriteLine("Sacado com sucesso;");
            ExibirDetalhesConta();
        }
    }

    public void Transferir(Conta alvoTranferencia, double valor)
    {
        if (saldo <= 0)
        {
            Console.WriteLine($"Saldo da conta {saldo} é menor ou igual 0, impossibilitado de realizar transferência");
        }
        else
        {
            Console.WriteLine("Antes transferencia");
            ExibirDetalhesConta();
            saldo = saldo - valor;
            alvoTranferencia.saldo += valor;
            Console.WriteLine($"Transferência realizada com sucesso para a {alvoTranferencia.Titular}");
        }
        ExibirDetalhesConta();
        Console.WriteLine("- Conta transferida -");
        alvoTranferencia.ExibirDetalhesConta();
    }
    public virtual double CalculoTributo()
    {
        Console.WriteLine("Calculando Tributo");
        return 0;
    }

    public virtual void ExibirDetalhesConta()
    {

        Console.WriteLine("########## Detalhes da Conta ##########");
        Console.WriteLine($"Titular da conta: {Titular}");
        Console.WriteLine($"Numero da conta: {Numero}");
        Console.WriteLine($"Tipo da conta: {Tipo}");
        Console.WriteLine($"Saldo da conta: ${saldo}");
    }
}
