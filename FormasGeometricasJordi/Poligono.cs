using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public abstract class Poligono : Forma
    {
        // Atributo común a todos los polígonos (protected set para que solo los hijos lo modifiquen)
        public int NumeroLados { get; protected set; }

        public override void Dibujar()
        {
            Console.WriteLine($"Dibujando un polígono de {NumeroLados} lados.");
        }

        // CalcularArea() sigue siendo abstracto porque cada polígono lo calcula diferente.
        public abstract override double CalcularArea();
    }
}
