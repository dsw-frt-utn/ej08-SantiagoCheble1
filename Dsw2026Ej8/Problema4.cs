using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma = 0;
            int cantidad = 0;

            void ValidarNota(int? nota)
            {
                if (nota.HasValue && nota >= 0 && nota <= 10)
                {
                    suma += nota.Value;
                    cantidad++;
                }
            }

            ValidarNota(nota1);
            ValidarNota(nota2);
            ValidarNota(nota3);

            if (cantidad == 0)
                return 0;

            double total = (double)suma/ cantidad;

            return total;
        }
    }
}
