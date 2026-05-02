namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var problema = new Problema5();
            Sale venta1 = new RetailSale();
            venta1._monto = 1000;
            Sale venta2 = new WholesaleSale();
            venta2._monto = 1000;

            Console.WriteLine(problema.ObtenerImporteFinal(venta1)); 
            Console.WriteLine(problema.ObtenerImporteFinal(venta2)); 
        }
    }
}
