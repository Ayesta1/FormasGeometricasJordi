using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public class Elipse : Forma
    {
        protected double EjeMayor { get; set; }
        protected double EjeMenor { get; set; }

        public Elipse(double mayor, double menor)
        {
            EjeMayor = mayor;
            EjeMenor = menor;
        }

        public override double CalcularArea()
        {
            return Math.PI * EjeMayor * EjeMenor;
        }
    }
}
