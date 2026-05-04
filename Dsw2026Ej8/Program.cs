namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper helper = new ProductHelper();

            long code = 12345;
            string description = "Coca Cola";
            decimal price = 2000.50m;

            String resultado = helper.ObtenerEtiquetaProducto (code, description, price);

            Console.WriteLine("La etiqueta generada es:");
            Console.WriteLine(resultado);
        }
    }
}
