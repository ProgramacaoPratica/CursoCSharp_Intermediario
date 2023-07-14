namespace ProjetoExemplo
{
    public class Program
    {
        public class Produto
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }

        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>()
            {
                new Produto { Nome = "TV", Preco = 1500 },
                new Produto { Nome = "Celular", Preco = 1000 },
                new Produto { Nome = "Notebook", Preco = 2000 }
            };

            decimal soma = produtos.Sum(p => p.Preco);
            decimal media = produtos.Average(p => p.Preco);
            decimal valorMaximo = produtos.Max(p => p.Preco);
            decimal valorMinimo = produtos.Min(p => p.Preco);

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");
            Console.WriteLine($"Valor máximo: {valorMaximo}");
            Console.WriteLine($"Valor mínimo: {valorMinimo}");
        }
    }
}
