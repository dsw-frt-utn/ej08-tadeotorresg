using Dsw2026Ej8;


namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema3 problema = new Problema3();
            int numeroOriginal = 5;
            Product miProducto = new Product("Teclado Viejo");

            
            string resultado = problema.CompararCopias(numeroOriginal, miProducto);

            
            Console.WriteLine("El resultado del Problema 3 es:");
            Console.WriteLine(resultado);

           
            Console.ReadLine();
        }
    }
}
