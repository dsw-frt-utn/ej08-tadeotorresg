using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal ImporteBase;

        public Sale (decimal ImporteBase)
            {
            this.ImporteBase = ImporteBase;
        }


        public virtual decimal CalculateTotal()
        {
            return ImporteBase;
        }
    }
}
