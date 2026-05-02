using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription,int quantity ,double unitPrice)
        {
            double total = quantity > 0 ? quantity * unitPrice : 0;


            var venta = new
            {
                Code = productCode,
                Product = productDescription,
                Quantity = quantity,
                Total = quantity * unitPrice
            };

            return $"{venta.Code} - {venta.Product} - {venta.Total}";
        }
    }
}
