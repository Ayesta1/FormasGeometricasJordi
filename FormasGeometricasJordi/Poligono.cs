using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    internal class Poligono : Forma
    {
        public int altura;
        public int ancho;
        public int numeroLados;
        public Poligono(int ancho, int altura, int numeroLados) 
        {
            this.altura = altura; 
            this.ancho = ancho;
            this.numeroLados = numeroLados;
        }

        public override string ToString()
        {
            return "Esto ya es un poligono";
        }
    }
}
