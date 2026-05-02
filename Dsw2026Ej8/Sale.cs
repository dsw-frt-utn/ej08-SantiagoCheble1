using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Sale
    {
        public decimal _monto;
        public virtual decimal CalculateTotal()
        {
            return _monto;
        }
    }
}
