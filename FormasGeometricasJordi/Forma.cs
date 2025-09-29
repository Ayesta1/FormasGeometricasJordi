using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public abstract class Forma
    {
        // Método abstracto: Obliga a todas las clases derivadas (Poligono, Elipse) a implementarlo.
        public abstract double CalcularArea();

        // Método virtual: Permite que las clases derivadas (Rectangulo, Circulo) lo modifiquen.
        public virtual void Dibujar()
        {
            Console.WriteLine("Dibujando una forma geométrica genérica.");
        }
    }
}
