using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public class Cuadrado : Rectangulo
    {
        public int Lado { get { return this.ancho; } }
        public Cuadrado(int lado) : base(lado, lado)
        {
            
        }
        public override void Dibujar()
        {
            Console.WriteLine($"Dibujando un polígono de {NumeroLados} lados heredado de rectangulo.");
        }
    }
}
