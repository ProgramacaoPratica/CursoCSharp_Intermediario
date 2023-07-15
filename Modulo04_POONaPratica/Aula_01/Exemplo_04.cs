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

    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var cao = new Cachorro();
            var gato = new Gato();

            cao.EmitirSom();
            gato.EmitirSom();
        }
    }
}
