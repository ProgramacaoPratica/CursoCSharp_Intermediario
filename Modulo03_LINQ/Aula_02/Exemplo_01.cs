namespace ProjetoExemplo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Filtragem de uma lista: Suponha que temos uma lista de números inteiros e queremos filtrar apenas os números pares
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPares = numeros.Where(n => n % 2 == 0);
            foreach (var numero in numerosPares)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
