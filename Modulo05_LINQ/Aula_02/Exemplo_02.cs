namespace ProjetoExemplo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>() { "João", "Maria", "Pedro", "Ana", "Lucas" };
            var nomesOrdenados = nomes.OrderBy(n => n);
            foreach (var nome in nomesOrdenados)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
