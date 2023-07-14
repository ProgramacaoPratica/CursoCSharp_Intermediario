namespace ProjetoExemplo
{
    public class Program
    {
        public class Estudante
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
        }

        static void Main(string[] args)
        {
            List<Estudante> estudantes = new List<Estudante>()
            {
                new Estudante { Nome = "João", Idade = 20 },
                new Estudante { Nome = "Maria", Idade = 18 },
                new Estudante { Nome = "Pedro", Idade = 20 },
                new Estudante { Nome = "Ana", Idade = 18 }
            };

            var estudantesPorIdade = estudantes.GroupBy(e => e.Idade);

            foreach (var grupo in estudantesPorIdade)
            {
                Console.WriteLine($"Idade: {grupo.Key}");
                foreach (var estudante in grupo)
                {
                    Console.WriteLine($"- {estudante.Nome}");
                }
            }
        }
    }
}
