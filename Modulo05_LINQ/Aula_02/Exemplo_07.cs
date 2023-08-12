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
            //Consulta com ordenação personalizada (OrderBy e ThenBy): Suponha que temos uma lista de produtos e queremos ordená-los por nome em ordem alfabética e, em caso de nomes iguais, por preço em ordem crescente
            List<Produto> produtos = new List<Produto>()
            {
                new Produto { Nome = "TV", Preco = 1500 },
                new Produto { Nome = "Celular", Preco = 1000 },
                new Produto { Nome = "Notebook", Preco = 2000 },
                new Produto { Nome = "TV", Preco = 1200 },
                new Produto { Nome = "Celular", Preco = 800 }
            };

            var produtosOrdenados = produtos.OrderBy(p => p.Nome).ThenBy(p => p.Preco);

            foreach (var produto in produtosOrdenados)
            {
                Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}");
            }
        }
    }
}
