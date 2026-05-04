using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class RetailSale : Sale
    {
        public RetailSale(decimal importeBase) : base(importeBase) { }

        public override decimal CalculateTotal()
        {
            return ImporteBase;
        }
    }
}

