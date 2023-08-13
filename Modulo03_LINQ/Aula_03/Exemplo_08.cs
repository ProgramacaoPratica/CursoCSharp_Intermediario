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
            //Consulta com projeção personalizada (Select): Suponha que temos uma lista de produtos e queremos obter uma nova lista apenas com o nome e o preço de cada produto
            List<Produto> produtos = new List<Produto>()
            {
                new Produto { Nome = "TV", Preco = 1500 },
                new Produto { Nome = "Celular", Preco = 1000 },
                new Produto { Nome = "Notebook", Preco = 2000 }
            };

            var nomesPrecos = produtos.Select(p => new { p.Nome, p.Preco });

            foreach (var item in nomesPrecos)
            {
                Console.WriteLine($"Nome: {item.Nome}, Preço: {item.Preco}");
            }
        }
    }
}
