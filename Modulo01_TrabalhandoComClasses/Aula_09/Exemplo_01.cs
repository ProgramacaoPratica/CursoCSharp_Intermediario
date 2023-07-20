namespace ProjetoExemplo
{
    public enum DiaSemana
    {
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado,
        Domingo
    }

    class Program
    {
        static void Main(string[] args)
        {
            DiaSemana dia = DiaSemana.Segunda;

            if (dia == DiaSemana.Sabado || dia == DiaSemana.Domingo)
            {
                Console.WriteLine("É fim de semana!");
            }
            else
            {
                Console.WriteLine("Não é fim de semana!");
            }
        }
    }
}
