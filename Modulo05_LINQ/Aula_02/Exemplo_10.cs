namespace ProjetoExemplo
{
    public class Program
    {
        public class Funcionario
        {
            public string Nome { get; set; }
            public decimal Salario { get; set; }
        }

        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>()
            {
                new Funcionario { Nome = "João", Salario = 6000 },
                new Funcionario { Nome = "Maria", Salario = 4500 },
                new Funcionario { Nome = "Pedro", Salario = 7000 },
                new Funcionario { Nome = "Ana", Salario = 5500 }
            };

            var funcionariosFiltrados = funcionarios.Where(f => f.Salario > 5000)
                                                   .Select(f => new { f.Nome, f.Salario });

            foreach (var funcionario in funcionariosFiltrados)
            {
                Console.WriteLine($"Nome: {funcionario.Nome}, Salário: {funcionario.Salario}");
            }
        }
    }
}
