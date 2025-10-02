using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public class Circulo : Elipse
    {

        public int Radio { get { return this.ejeMayor; } }
        public int RadioBIS { get { return this.ejeMayor; } }
        public Circulo(int radio) : base(radio, radio)
        {
            
        }
        public override void Dibujar()
        {
            Console.WriteLine($"Dibujando un polígono de forma geométrica genérica heredada de Elipse.");
        }
    }
}
