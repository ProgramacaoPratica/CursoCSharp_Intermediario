namespace ProjetoExemplo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Consulta com agregação (Aggregate): Suponha que temos uma lista de números inteiros e queremos obter a soma de todos os números
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };

            int soma = numeros.Aggregate((acc, num) => acc + num);

            Console.WriteLine($"Soma: {soma}");
        }
    }
}
