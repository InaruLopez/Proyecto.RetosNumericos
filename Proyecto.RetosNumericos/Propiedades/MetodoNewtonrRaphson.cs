using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.RetosNumericos.Propiedades
{
    public class MetodoNewtonrRaphson : Metodo
    {
        public void CalcularRaiz(double x0)
        {
            while (fPrima(x0) != 0)
            {
                Iteraciones++;
            }
        }
    }
}
