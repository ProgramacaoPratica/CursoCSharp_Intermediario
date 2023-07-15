namespace ProjetoExemplo
{
    public class Exemplo
    {
        public static int Contador { get; set; }
        public string Nome { get; set; }

        static Exemplo()
        {
            Contador = 0;
        }

        public Exemplo(string nome)
        {
            Nome = nome;
            Contador++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exemplo obj1 = new Exemplo("Objeto 1");
            Exemplo obj2 = new Exemplo("Objeto 2");

            Console.WriteLine($"Contador: {Exemplo.Contador}");
            // Saída: Contador: 2
        }
    }
}
