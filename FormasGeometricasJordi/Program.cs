using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasJordi
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static List<Forma> Formas = new List<Forma>();

        public static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion.ToLower())
                {
                    case "1":
                        CrearNuevaForma();
                        break;
                    case "2":
                        Diagrama miDiagrama = new Diagrama(Formas);
                        miDiagrama.MostrarCalculos();
                        break;
                    case "3":
                        Console.WriteLine("¡Gracias por usar el programa de figuras geométricas! Adiós.");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }
                Console.WriteLine("\nPresiona Enter para continuar...");
                Console.ReadLine();
            }
        }

        private static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("       GESTOR DE FIGURAS GEOMÉTRICAS");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. Crear Nueva Forma");
            Console.WriteLine("2. Mostrar Todas las Formas y sus Áreas");
            Console.WriteLine("3. Salir");
            Console.WriteLine("-------------------------------------");
            Console.Write("Seleccione una opción: ");
        }

        private static void CrearNuevaForma()
        {
            Console.Clear();
            Console.WriteLine("--- ¿Qué forma desea crear? ---");
            Console.WriteLine("R: Rectángulo");
            Console.WriteLine("O: Círculo");
            Console.WriteLine("T: Triángulo");
            Console.Write("Ingrese la letra de la forma: ");
            string tipo = Console.ReadLine().ToUpper();

            try
            {
                Forma nuevaForma = null;

                switch (tipo)
                {
                    case "R":
                        Console.Write("Ingrese Ancho: ");
                        int ancho = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese Altura: ");
                        int alto = int.Parse(Console.ReadLine());
                        nuevaForma = new Rectangulo(ancho, alto);
                        break;

                    case "O":
                        Console.Write("Ingrese Radio: ");
                        int radio = int.Parse(Console.ReadLine());
                        nuevaForma = new Circulo(radio);
                        break;

                    case "T":
                        Console.Write("Ingrese Base: ");
                        int baseT = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese Altura: ");
                        int alturaT = int.Parse(Console.ReadLine());
                        nuevaForma = new Triangulo(baseT, alturaT);
                        break;

                    case "C":
                        Console.WriteLine("Ingrese Base: ");
                        int lado = int.Parse(Console.ReadLine());
                        nuevaForma = new Cuadrado(lado);
                        break;
                    case "D":
                        Console.WriteLine("Ingrese Diagonal Mayor: ");
                        int diagonalMa = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Diagonal Menor: ");
                        int diagonalMe = int.Parse(Console.ReadLine());
                        nuevaForma = new Rombo(diagonalMa, diagonalMe);
                        break;
                    case "":
                        Console.WriteLine("Ingrese Eje Mayor: ");
                        int ejeMayor = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Eje Menor: ");
                        int ejeMenor = int.Parse(Console.ReadLine());
                        nuevaForma = new Elipse(ejeMayor, ejeMenor);
                        break;



                    default:
                        Console.WriteLine("Tipo de forma no reconocido.");
                        return;
                }

                if (nuevaForma != null)
                {
                    Formas.Add(nuevaForma);
                    Console.WriteLine($"\n¡{nuevaForma.GetType().Name} creado y añadido a la lista!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: Ingrese un valor numérico válido para las dimensiones.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nOcurrió un error inesperado: {ex.Message}");
            }
        }
    }
}
