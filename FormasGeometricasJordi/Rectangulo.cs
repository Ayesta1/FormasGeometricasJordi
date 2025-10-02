using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public class Rectangulo : Poligono
    {
        protected int ancho;
        protected int alto;
        public int Ancho { get => ancho; set => ancho = value; }
        public int Alto { get => alto; set => alto = value; }

        public Rectangulo(int ancho, int alto) : base(4)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public override double CalcularArea()
        {
            return Ancho * Alto;
        }
    }
}
