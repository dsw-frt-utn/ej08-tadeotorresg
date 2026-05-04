using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema2
    {
        public string CrearResumenVenta(long productcode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total = 0;

            if (quantity > 0)
            {
                total = quantity * unitPrice;
            }
              
            var venta = new
            {
                Code = productcode,
                Description = productDescription,
                Quantity = quantity,
                Total = total
            };

            return $"{venta.Code} - {venta.Description} - {venta.Total}";


        }
    }
}
