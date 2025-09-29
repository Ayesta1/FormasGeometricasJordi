using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public class Circulo : Elipse
    {
        public double Radio
        {
            get => EjeMayor;
            set
            {
                EjeMayor = value;
                EjeMenor = value;
            }
        }

        // Llama al constructor base (Elipse) para inicializar los ejes con el radio.
        public Circulo(double radio) : base(radio, radio)
        {
            // No necesita redefinir CalcularArea, ya que la fórmula de la Elipse (pi*EjeMayor*EjeMenor) ya funciona.
        }
    }
}
