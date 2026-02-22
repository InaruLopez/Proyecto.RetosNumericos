using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Proyecto.RetosNumericos.Propiedades
{
    public class Metodo
    {
        //Teamo
        //Propiedades
        public int Iteraciones { get; set; }
        public int EvaluacionesFuncion { get; set; }
        public int EvaluacionesDerivada { get; set; }
        public double RaizAproximada { get; set; }
        public double XNueva { get; set; }
        public double XVieja { get; set; }

        public double ErrorRelativo
        {
            get
            {
                double Ea = Math.Abs(XNueva - XVieja);
                return Ea / Math.Abs(XNueva);
            }
        }

        public double f(double x)
        {
            return x;
        }

        public double fPrima(double x)
        {
            return 1; 
        }

    }
}
