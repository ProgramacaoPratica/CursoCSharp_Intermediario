namespace ProjetoExemplo
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "João";
            pessoa.Idade = 25;

            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
            // Saída: Nome: João, Idade: 25
        }
    }
}
