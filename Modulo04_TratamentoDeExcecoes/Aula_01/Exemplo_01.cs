namespace ProjetoExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int dividendo = 10;
                int divisor = 0;
                int resultado = dividendo / divisor;
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Erro de divisão por zero!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
