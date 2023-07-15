namespace ProjetoExemplo
{
    public interface IAnimal
    {
        void EmitirSom();
        string Descricao { get; set; }
    }

    public class Cachorro : IAnimal
    {
        public string Descricao { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Au au!");
        }
    }

    public class Gato : IAnimal
    {
        public string Descricao { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal1 = new Cachorro();
            animal1.Descricao = "Animal: Cachorro";
            animal1.EmitirSom();

            IAnimal animal2 = new Gato();
            animal2.Descricao = "Animal: Gato";
            animal2.EmitirSom();
        }
    }
}
