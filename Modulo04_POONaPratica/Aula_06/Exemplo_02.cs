namespace ProjetoExemplo
{
    public class Animal
    {
        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal emite um som genérico.");
        }
    }

    public class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O cachorro late: Au au!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Animal animal2 = new Cachorro();

            animal1.EmitirSom();
            animal2.EmitirSom();
        }
    }
}
