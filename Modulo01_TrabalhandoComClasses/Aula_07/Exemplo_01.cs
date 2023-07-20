namespace ProjetoExemplo
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
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
