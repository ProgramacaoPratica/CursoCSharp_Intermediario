namespace ProjetoExemplo
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public double Somar(double a, double b)
        {
            return a + b;
        }

        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            int resultado1 = calculadora.Somar(2, 3);
            double resultado2 = calculadora.Somar(1.5, 2.5);
            int resultado3 = calculadora.Somar(1, 2, 3);

            Console.WriteLine($"Resultado 1: {resultado1}");
            Console.WriteLine($"Resultado 2: {resultado2}");
            Console.WriteLine($"Resultado 3: {resultado3}");
        }
    }

}
