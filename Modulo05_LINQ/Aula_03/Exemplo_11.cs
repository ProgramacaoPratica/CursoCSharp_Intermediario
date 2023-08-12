namespace ProjetoExemplo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Consulta com operações de conjunto (Distinct, Union, Intersect, Except): Suponha que temos duas listas de números e queremos obter os números distintos, a união de ambos, a interseção entre eles e a diferença entre as duas listas
            List<int> lista1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> lista2 = new List<int>() { 4, 5, 6, 7, 8 };

            var numerosDistintos = lista1.Distinct();
            var uniao = lista1.Union(lista2);
            var intersecao = lista1.Intersect(lista2);
            var diferenca = lista1.Except(lista2);

            Console.WriteLine("Números distintos:");
            foreach (var numero in numerosDistintos)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("União de ambas as listas:");
            foreach (var numero in uniao)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Interseção entre as listas:");
            foreach (var numero in intersecao)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Diferença entre as listas (lista1 - lista2):");
            foreach (var numero in diferenca)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
