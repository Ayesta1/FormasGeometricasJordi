using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{

    public class Diagrama 
    {
        private readonly List<Forma> Formas;

        public Diagrama(List<Forma> formas) 
        {
            Formas = formas;
        }

        // Metodo para calcular el area total de las figuras creadas
        public double CalcularAreaTotal()
        {
            double areaTotal = 0;

            foreach (var forma in Formas)
            {
                areaTotal += forma.CalcularArea();
            }

            return areaTotal; 
        }

        // Metodo para mostrar la informacion de las figuras creadas
        public void MostrarCalculos()
        {
            Console.Clear();
            if (Formas == null || Formas.Count == 0)
            {
                Console.WriteLine("Aún no hay figuras creadas.");
                return;
            }

            Console.WriteLine("--- Listado de Formas y Cálculos ---");

            double areaTotal = 0; 

            foreach (var forma in Formas)
            {
                double area = forma.CalcularArea();
                areaTotal += area; 

                
                Console.WriteLine($"\nTipo: {forma.GetType().Name}");
                forma.Dibujar();
                Console.WriteLine($"Área Calculada: {area:F2}");

                if (forma is Rectangulo rect)
                {
                    Console.WriteLine($"  -> Dimensiones: {rect.Ancho} x {rect.Alto}");
                }
                else if (forma is Circulo circulo)
                {
                    Console.WriteLine($"  -> Radio: {circulo.Radio}");
                }
                else if (forma is Cuadrado cuadra)
                {
                    Console.WriteLine($"  -> Dimensiones: {cuadra.Lado}");
                }
                else if (forma is Rombo romb)
                {
                    Console.WriteLine($"  -> Diagonal Mayor: {romb.DiagonalMayor} y Diagonal Menor: {romb.DiagonalMenor} ");
                }
                else if (forma is Elipse elip)
                {
                    Console.WriteLine($"  -> Eje Mayor: {elip.EjeMayor} y Eje Menor: {elip.EjeMenor} ");
                }
            }

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine($"ÁREA TOTAL DE TODAS LAS FORMAS: {areaTotal:F2}");
            Console.WriteLine("-------------------------------------");
        }
    }
}

    
