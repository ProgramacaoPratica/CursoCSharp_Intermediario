using System;

namespace ExemploMetodoExtensao
{
    public static class IntExtensions
    {
        public static int Quadrado(this int numero)
        {
            return numero * numero;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            int resultado = numero.Quadrado();
            
            Console.WriteLine($"O quadrado de {numero} é {resultado}");
            // Saída: O quadrado de 5 é 25
        } 
    }
}
