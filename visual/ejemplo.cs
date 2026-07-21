using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EjercicioMetodos
{
    class Program
    {
        static string[,] estudiantes = new string[10, 3];
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Registrar");
                Console.WriteLine("2. Mostrar");
                Console.WriteLine("3. Actualizar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("=== REGISTRAR ESTUDIANTES ===");
                        Registrar();
                        Pausa();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("=== MOSTRAR ESTUDIANTES ===");
                        MostrarE();
                        Pausa();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("=== ACTUALIZAR ESTUDIANTES ===");
                        Actualizar();
                        Pausa();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("=== ELIMINAR ESTUDIANTES ===");
                        Eliminar();
                        Pausa();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        Pausa();
                        break;
                }
            } while (opcion != 5);
        }
        // Método Registrar
        static void Registrar()
        {
            bool registrado = false;
            for (int i = 0; i < 3; i++)
            {
                if (string.IsNullOrEmpty(estudiantes[i, 0]))
                {
                    Console.Write("Código: ");
                    estudiantes[i, 0] = Console.ReadLine();
                    Console.Write("Nombre: ");
                    estudiantes[i, 1] = Console.ReadLine();
                    Console.Write("Edad: ");
                    estudiantes[i, 2] = Console.ReadLine();
                    Console.WriteLine("\nEstudiante registrado.");
                    registrado = true;
                    break;
                }
            }
            if (!registrado)
            {
                Console.WriteLine("\nLa matriz está llena.");
            }
        }
        // Método Mostrar
        static void MostrarE()
        {
            Console.WriteLine("\nCODIGO\tNOMBRE\t\tEDAD");
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < 10; i++
                {
                if (!string.IsNullOrEmpty(estudiantes[i, 0]))
                {
                    Console.WriteLine(
                    estudiantes[i, 0] + "\t" +
                    estudiantes[i, 1] + "\t\t" +
                    estudiantes[i, 2]);
                }
            }
        }
        // Método Actualizar
        static void Actualizar()
        {
            string codigo;
            bool encontrado = false;
            Console.Write("Código a buscar: ");
            codigo = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (estudiantes[i, 0] == codigo)
                {
                    Console.Write("Nuevo nombre: ");
                    estudiantes[i, 1] = Console.ReadLine();
                    Console.Write("Nueva edad: ");
                    estudiantes[i, 2] = Console.ReadLine();
                    Console.WriteLine("\nRegistro actualizado.");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("\nCódigo no encontrado.");
            }
        }
        // Método Eliminar
        static void Eliminar()
        {
            string codigo;
            bool encontrado = false;
            Console.Write("Código a eliminar: ");
            codigo = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (estudiantes[i, 0] == codigo)
                {
                    estudiantes[i, 0] = "";
                    estudiantes[i, 1] = "";
                    estudiantes[i, 2] = "";
                    Console.WriteLine("\nRegistro eliminado.");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("\nCódigo no encontrado.");
            }
        }
        // Método Pausa
        static void Pausa()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}