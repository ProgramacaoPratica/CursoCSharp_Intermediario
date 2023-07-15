namespace ProjetoExemplo
{
    public abstract class Animal
    {
        public abstract void EmitirSom();
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
            var cao = new Cachorro();
            cao.EmitirSom();
        }
    }
}
