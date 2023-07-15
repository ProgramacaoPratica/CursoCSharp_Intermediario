namespace ProjetoExemplo
{
    public sealed class Carro
    {
        public void Acelerar()
        {
            Console.WriteLine("O carro está acelerando.");
        }
    }

    public class Sedan : Carro // Erro! A classe 'Sedan' não pode herdar da classe selada 'Carro'.
    {
        // ...
    }

    class Program
    {

    }
}
