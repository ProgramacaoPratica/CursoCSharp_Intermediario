namespace ProjetoExemplo
{
    public class Animal
    {
        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal está emitindo um som.");
        }
    }

    public class Cachorro : Animal
    {
        public sealed override void EmitirSom()
        {
            Console.WriteLine("O cachorro está latindo.");
        }
    }

    public class PastorAlemao : Cachorro
    {
        public override void EmitirSom() // Erro! O método selado 'EmitirSom' não pode ser substituído.
        {
            // ...
        }
    }

    class Program
    {

    }
}
