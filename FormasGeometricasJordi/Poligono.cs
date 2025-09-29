using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public abstract class Poligono : Forma
    {
        public int NumeroLados { get; protected set; }

        // El método de cálculo sigue siendo abstracto y se implementa abajo
        public abstract override double CalcularArea();
    }
}
