using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int valorCopia = originalValue;
            valorCopia++;

            var producto = product;
            producto.setDescripcion("cambiando la descripcion");

            return $"{originalValue} - {valorCopia} - {producto.getDescripcion()} ";
        }
    }
}
