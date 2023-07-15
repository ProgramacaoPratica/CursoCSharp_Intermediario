using System;
using System.Collections.Generic;
using System.Linq;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa { Nome = "João", Idade = 25 },
            new Pessoa { Nome = "Maria", Idade = 17 },
            new Pessoa { Nome = "Pedro", Idade = 30 },
            new Pessoa { Nome = "Ana", Idade = 20 }
        };

        var pessoasMaioresDe18 = pessoas.Where(p => p.Idade > 18);

        foreach (var pessoa in pessoasMaioresDe18)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
        }
    }
}
