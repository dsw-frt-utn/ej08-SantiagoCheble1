using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal partial class  ProductHelper
    {
        public String ObtenerEtiquetaProducto(long code,string descripcion, double precio)
        {
            return $"[{code}] {descripcion} - {obtenerPrecio(precio)}";
        }

    }
}
