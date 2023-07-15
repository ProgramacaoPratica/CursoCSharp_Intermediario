namespace ProjetoExemplo
{
    public class Veiculo
    {
        public void Mover()
        {
            Console.WriteLine("O veículo está se movendo.");
        }
    }

    public class Carro : Veiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("O carro está acelerando.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro();
            carro.Mover();
            carro.Acelerar();
        }
    }
}
