using Dsw2026Ej8;


namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema5 prob5 = new Problema5();

            
            Sale ventaMinorista = new RetailSale(1000m);
            Sale ventaMayorista = new WholesaleSale(1000m);

            
            decimal totalMinorista = Problema5.ObtenerImporteFinal(ventaMinorista);
            Console.WriteLine($"Total Minorista: {totalMinorista}"); 

            
            decimal totalMayorista = Problema5.ObtenerImporteFinal(ventaMayorista);
            Console.WriteLine($"Total Mayorista: {totalMayorista}"); 

            Console.ReadLine();
        }
    }
}
