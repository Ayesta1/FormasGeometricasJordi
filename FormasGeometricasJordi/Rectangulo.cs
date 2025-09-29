using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public class Rectangulo : Poligono
    {
        // Solo Rectangulo (y Cuadrado por herencia) tienen estas propiedades
        public double Altura { get; set; }
        public double Ancho { get; set; }

        public Rectangulo(double ancho, double altura)
        {
            NumeroLados = 4;
            Ancho = ancho;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Ancho * Altura;
        }
    }
}
