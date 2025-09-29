using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    internal class Triangulo : Poligono
    {
        public Triangulo(int altura, int ancho, int numeroLados) : base(altura, ancho, numeroLados) { }

        public override string ToString()
        {
            return "Esto ya es un triangulo";
        }
    }
}
