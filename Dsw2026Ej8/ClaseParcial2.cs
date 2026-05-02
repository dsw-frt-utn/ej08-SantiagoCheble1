using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal partial class ProductHelper
    {
        public string obtenerPrecio(double precio)
        {
            return $"${precio:F2}";
        }
    }
}
