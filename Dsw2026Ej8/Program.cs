using Dsw2026Ej8;


namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Problema4 prob4 = new Problema4();

           
            double prom = prob4.CalcularPromedio(8, 10, 6);
            Console.WriteLine($"Prueba 1: {prom}"); 
        }
    }
}
