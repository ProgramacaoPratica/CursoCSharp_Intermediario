namespace ProjetoExemplo
{
    public class Animal
    {
        public void Respirar()
        {
            Console.WriteLine("O animal está respirando.");
        }
    }

    public class Mamifero : Animal
    {
        public void Amamentar()
        {
            Console.WriteLine("O mamífero está amamentando.");
        }
    }

    public class Cachorro : Mamifero
    {
        public void Latir()
        {
            Console.WriteLine("O cachorro está latindo.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();
            cachorro.Respirar();
            cachorro.Amamentar();
            cachorro.Latir();
        }
    }

}
