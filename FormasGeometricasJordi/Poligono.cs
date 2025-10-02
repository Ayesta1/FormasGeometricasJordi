using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public abstract class Poligono : Forma
    {
        
        public int NumeroLados { get; set; }

        public Poligono(int numeroLados) 
        { 
            NumeroLados = numeroLados;
        }
        public override void Dibujar()
        {
            Console.WriteLine($"Dibujando un polígono de {NumeroLados} lados.");
        }
    }
}
