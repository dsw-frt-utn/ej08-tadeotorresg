using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal importeBase) : base(importeBase) { }

        public override decimal CalculateTotal()
        {
            decimal descuento = ImporteBase * 0.10m;
            return ImporteBase - descuento;
        }
    }
}
