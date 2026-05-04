using Dsw2026Ej8;


namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema6 prob6 = new Problema6();

            
            string codigoEjemplo = " ab 123 x ";
            string resultado1 = prob6.NormalizarCodigoProducto(codigoEjemplo);
            Console.WriteLine($"Prueba Ejemplo: {resultado1}");
        }
    }
}
