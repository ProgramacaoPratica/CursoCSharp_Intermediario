namespace ProjetoExemplo
{
    public class SaldoInsuficienteException : Exception
    {
        public decimal SaldoDisponível { get; }

        public SaldoInsuficienteException(decimal saldoDisponível)
        {
            SaldoDisponível = saldoDisponível;
        }

        public override string Message => "Saldo insuficiente. Saldo disponível: " + SaldoDisponível;
    }

    public class Conta
    {
        public decimal Saldo { get; set; }

        public Conta(decimal saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(decimal valorSacar)
        {
            try
            {
                if (Saldo - valorSacar <= 0)
                    throw new SaldoInsuficienteException(Saldo);

                Saldo = Saldo - valorSacar;
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta(1000);
            conta.Sacar(1100);
        }
    }
}
