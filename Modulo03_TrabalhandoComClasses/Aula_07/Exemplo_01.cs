namespace ProjetoExemplo
{
    public class Exemplo
    {
        public readonly int ValorFixo;

        public Exemplo(int valor)
        {
            ValorFixo = valor;
        }

        public void ImprimirValor()
        {
            Console.WriteLine($"Valor Fixo: {ValorFixo}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exemplo exemplo = new Exemplo(10);
            exemplo.ImprimirValor();

            // exemplo.ValorFixo = 20; // Erro! O atributo readonly não pode ser modificado após a inicialização.
        }
    }
}
