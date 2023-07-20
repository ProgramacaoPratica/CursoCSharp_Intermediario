public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("João", 25);
        Pessoa pessoa2 = new Pessoa("Maria", 30);
        
        Console.WriteLine($"Nome: {pessoa1.Nome}, Idade: {pessoa1.Idade}");
        Console.WriteLine($"Nome: {pessoa2.Nome}, Idade: {pessoa2.Idade}");
    }
}
