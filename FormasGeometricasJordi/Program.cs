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

    // Supongamos que todas tus clases (Forma, Rectangulo, Circulo, etc.)
    // están definidas en el mismo namespace o archivo.

    public class Program
    {
        // Una lista para almacenar todas las figuras creadas
        private static List<Forma> Formas = new List<Forma>();

        public static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                // Usamos un switch para manejar las opciones del menú
                switch (opcion.ToLower())
                {
                    case "1":
                        CrearNuevaForma();
                        break;
                    case "2":
                        MostrarCalculos();
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

        // --- Métodos del Menú ---

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
            Console.WriteLine("C: Círculo");
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
                        double ancho = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese Altura: ");
                        double altura = double.Parse(Console.ReadLine());
                        nuevaForma = new Rectangulo(ancho, altura);
                        break;

                    case "C":
                        Console.Write("Ingrese Radio: ");
                        double radio = double.Parse(Console.ReadLine());
                        nuevaForma = new Circulo(radio);
                        break;

                    case "T":
                        Console.Write("Ingrese Base: ");
                        double baseT = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese Altura: ");
                        double alturaT = double.Parse(Console.ReadLine());
                        nuevaForma = new Triangulo(baseT, alturaT);
                        break;

                    // Puedes agregar Rombo y Cuadrado aquí
                    // case "S": nuevaForma = new Cuadrado(...); break; 

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

        private static void MostrarCalculos()
        {
            Console.Clear();
            if (Formas.Count == 0)
            {
                Console.WriteLine("Aún no hay figuras creadas.");
                return;
            }

            Console.WriteLine("--- Listado de Formas y Cálculos ---");
            double areaTotal = 0;

            foreach (var forma in Formas)
            {
                // Gracias al polimorfismo, llama al método CalcularArea() específico de cada clase (Rectangulo, Circulo, etc.)
                double area = forma.CalcularArea();
                areaTotal += area;

                // GetType().Name obtiene el nombre de la clase real (ej: "Rectangulo")
                Console.WriteLine($"\nTipo: {forma.GetType().Name}");
                forma.Dibujar(); // Llama al método Dibujar() especializado
                Console.WriteLine($"Área Calculada: {area:F2}"); // :F2 para dos decimales

                // Puedes agregar información específica usando 'as' o 'is'
                if (forma is Rectangulo rect)
                {
                    Console.WriteLine($"  -> Dimensiones: {rect.Ancho} x {rect.Altura}");
                }
                else if (forma is Circulo circulo)
                {
                    Console.WriteLine($"  -> Radio: {circulo.Radio}");
                }
            }

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine($"ÁREA TOTAL DE TODAS LAS FORMAS: {areaTotal:F2}");
            Console.WriteLine("-------------------------------------");
        }
    }
}
