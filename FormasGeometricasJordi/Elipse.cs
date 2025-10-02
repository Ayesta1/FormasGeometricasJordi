using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    public class Elipse : Forma
    {
        protected int ejeMayor;
        protected int ejeMenor;
        public int EjeMayor { get => ejeMayor; set => ejeMayor = value; }
        public int EjeMenor { get => ejeMenor; set => ejeMenor = value; }

        public Elipse(int ejeMayor, int ejeMenor)
        {
            this.ejeMayor = ejeMayor;
            this.ejeMenor = ejeMenor;
        }

        public override double  CalcularArea()
        {
            return ejeMayor * ejeMenor * Math.PI;
        }
    }
}
