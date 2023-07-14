namespace ProjetoExemplo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };

            int soma = numeros.Aggregate((acc, num) => acc + num);

            Console.WriteLine($"Soma: {soma}");
        }
    }
}
