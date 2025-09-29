using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public class Triangulo : Poligono
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double b, double a)
        {
            NumeroLados = 3;
            Base = b;
            Altura = a;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }
}
