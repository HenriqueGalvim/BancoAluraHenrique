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
        Console.WriteLine("\n------------- Depositando -------------\n");
        Saldo += valor;
        Console.WriteLine($"Foi depositado R${valor} na conta {Titular}\n\n");
    }

    public virtual void Sacar(double valor)
    {
        Console.WriteLine("\n------------- Sacando -------------\n");
        if (saldo <= 0)
        {
            Console.WriteLine($"Saldo da conta {Saldo} é menor ou igual 0, impossibilitado de sacar\n\n");
        }
        else
        {
            saldo -= valor;
            Console.WriteLine($"Sacado R${valor} com sucesso da conta {Titular}\n\n");
        }
    }

    public void Transferir(Conta alvoTranferencia, double valor)
    {
        Console.WriteLine("\n------------- Transferindo -------------\n");
        if (saldo <= 0)
        {
            Console.WriteLine($"Saldo da conta {saldo} é menor ou igual 0, impossibilitado de realizar transferência\n\n");
        }
        else
        {
            saldo = saldo - valor;
            alvoTranferencia.saldo += valor;
            Console.WriteLine($"Transferência realizada com sucesso para a {alvoTranferencia.Titular}\n\n");
        }
    }
    public virtual double CalculoTributo()
    {
        return 0;
    }

    public virtual void ExibirDetalhesConta()
    {

        Console.WriteLine("\n########## Detalhes da Conta ##########\n");
        Console.WriteLine($"Titular da conta: {Titular}");
        Console.WriteLine($"Numero da conta: {Numero}");
        Console.WriteLine($"Tipo da conta: {Tipo}");
        Console.WriteLine($"Saldo da conta: ${saldo}");
        Console.WriteLine("");
    }
}
