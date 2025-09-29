using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public class Rectangulo : Poligono
    {
        public double Ancho { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double ancho, double altura)
        {
            // Inicializa la propiedad heredada de Poligono
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
