using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public class Rombo : Poligono
    {
        public double DiagonalMayor { get; set; }
        public double DiagonalMenor { get; set; }

        public Rombo(double dMayor, double dMenor) : base(4)
        {
            DiagonalMayor = dMayor;
            DiagonalMenor = dMenor;
        }

        public override double CalcularArea()
        {
            return (DiagonalMayor * DiagonalMenor) / 2;
        }
    }
}
