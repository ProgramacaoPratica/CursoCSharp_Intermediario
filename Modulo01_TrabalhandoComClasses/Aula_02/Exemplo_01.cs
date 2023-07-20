namespace ProjetoExemplo
{
    public static class Calculadora
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int resultadoSoma = Calculadora.Somar(20, 50);
            int resultadoSubtracao = Calculadora.Subtrair(90, 45);

            Console.WriteLine($"Soma: {resultadoSoma}");
            Console.WriteLine($"Subtração: {resultadoSubtracao}");
        }
    }
}
