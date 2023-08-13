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
            //Projeção de uma lista: Suponha que temos uma lista de produtos e queremos obter apenas os nomes dos produtos:
            List<Produto> produtos = new List<Produto>()
            {
                new Produto { Nome = "Celular", Preco = 1000 },
                new Produto { Nome = "TV", Preco = 1500 },
                new Produto { Nome = "Notebook", Preco = 2000 }
            };

            var nomesProdutos = produtos.Select(p => p.Nome);

            foreach (var nome in nomesProdutos)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
