namespace ProjetoExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Código que pode lançar uma exceção
            }
            catch (ExceptionTipoA ex)
            {
                // Tratamento para ExcecaoTipoA
            }
            catch (ExceptionTipoB ex)
            {
                // Tratamento para ExceptionTipoB
            }
            finally
            {
                // Código a ser executado sempre, independente da ocorrência de exceções
            }
        }
    }
}
