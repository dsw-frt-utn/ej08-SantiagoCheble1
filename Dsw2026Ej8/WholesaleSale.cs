using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return (_monto - (_monto * 0.1m));
        }
    }
}
