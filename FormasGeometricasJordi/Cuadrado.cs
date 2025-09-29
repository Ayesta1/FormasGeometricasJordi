using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public class Cuadrado : Rectangulo
    {
        // El constructor de Cuadrado solo necesita 'lado', pero llama al de Rectangulo.
        public Cuadrado(double lado) : base(lado, lado)
        {
            // No necesita redefinir Ancho, Altura o CalcularArea.
        }
    }
}
