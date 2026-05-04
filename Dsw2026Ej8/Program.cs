namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema2 venta = new Problema2();

            String resultado = venta.CrearResumenVenta(12345, "Agua Mineral", 3, 2000.50m);

            Console.WriteLine("La etiqueta generada es:");
            Console.WriteLine(resultado);
        }
    }
}
