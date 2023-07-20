namespace ProjetoExemplo
{
    public class ContaBancaria
    {
        private decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= saldo)
                saldo -= valor;
            else
                Console.WriteLine("Saldo insuficiente.");
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine(saldo.ToString("C"));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var conta = new ContaBancaria();
            conta.Depositar(100);
            conta.ConsultarSaldo();
            conta.Sacar(10);
            conta.ConsultarSaldo();
        }
    }
}
