namespace ProjetoExemplo
{
    public abstract class Animal
    {
        public string Nome { get; set; }

        public abstract void EmitirSom();

        public void Dormir()
        {
            Console.WriteLine($"{Nome} está dormindo.");
        }
    }

    public class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Au au!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Rex";
            cachorro.EmitirSom();
            cachorro.Dormir();
        }
    }
}
