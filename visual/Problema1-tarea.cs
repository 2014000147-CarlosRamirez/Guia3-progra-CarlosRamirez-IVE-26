internal class Program
{
    private static void Main(string[] args)
    {
        // Matriz de 10 filas y 3 columnas
        // Columna 0 = Código, Columna 1 = Nombre, Columna 2 = Cantidad
        string[,] inventario = new string[10, 3];

        int opcion;

        // Inicializamos todas las filas como vacías
        for (int i = 0; i < 10; i++)
        {
            inventario[i, 0] = "";
            inventario[i, 1] = "";
            inventario[i, 2] = "";
        }

        do
        {
            // Mostramos el menú principal
            Console.WriteLine("\n===== MENÚ =====");
            Console.WriteLine("1. Registrar producto");
            Console.WriteLine("2. Mostrar productos");
            Console.WriteLine("3. Actualizar producto");
            Console.WriteLine("4. Eliminar producto");
            Console.WriteLine("5. Salir");
            Console.Write("Elija una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Buscamos el primer espacio disponible (fila vacía)
                int espacioDisponible = -1;
                for (int i = 0; i < 10; i++)
                {
                    if (inventario[i, 0] == "")
                    {
                        espacioDisponible = i;
                        break;
                    }
                }

                // Si encontramos espacio, registramos el producto
                if (espacioDisponible != -1)
                {
                    Console.Write("Ingrese el código del producto: ");
                    inventario[espacioDisponible, 0] = Console.ReadLine();

                    Console.Write("Ingrese el nombre del producto: ");
                    inventario[espacioDisponible, 1] = Console.ReadLine();

                    Console.Write("Ingrese la cantidad en existencia: ");
                    inventario[espacioDisponible, 2] = Console.ReadLine();

                    Console.WriteLine("Producto registrado correctamente.");
                }
                else
                {
                    // No hay espacio en el inventario
                    Console.WriteLine("El inventario está lleno. No se pueden registrar más productos.");
                }
            }
            else if (opcion == 2)
            {
                // Mostramos todos los productos registrados
                Console.WriteLine("\n--- Productos registrados ---");
                bool hayProductos = false;

                for (int i = 0; i < 10; i++)
                {
                    if (inventario[i, 0] != "")
                    {
                        Console.WriteLine("Código: " + inventario[i, 0] +
                                          " | Nombre: " + inventario[i, 1] +
                                          " | Cantidad: " + inventario[i, 2]);
                        hayProductos = true;
                    }
                }

                if (!hayProductos)
                {
                    Console.WriteLine("No hay productos registrados.");
                }
            }
            else if (opcion == 3)
            {
                // Buscamos el producto por código para actualizarlo
                Console.Write("Ingrese el código del producto a actualizar: ");
                string codigoBuscar = Console.ReadLine();

                bool encontrado = false;
                for (int i = 0; i < 10; i++)
                {
                    if (inventario[i, 0] == codigoBuscar)
                    {
                        // Mostramos los datos actuales
                        Console.WriteLine("Producto encontrado: " + inventario[i, 1] +
                                          " | Cantidad: " + inventario[i, 2]);

                        // Pedimos los nuevos datos
                        Console.Write("Ingrese el nuevo nombre (Enter para mantener actual): ");
                        string nuevoNombre = Console.ReadLine();
                        if (nuevoNombre != "")
                        {
                            inventario[i, 1] = nuevoNombre;
                        }

                        Console.Write("Ingrese la nueva cantidad (Enter para mantener actual): ");
                        string nuevaCantidad = Console.ReadLine();
                        if (nuevaCantidad != "")
                        {
                            inventario[i, 2] = nuevaCantidad;
                        }

                        Console.WriteLine("Producto actualizado correctamente.");
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("No se encontró un producto con ese código.");
                }
            }
            else if (opcion == 4)
            {
                // Buscamos el producto por código para eliminarlo
                Console.Write("Ingrese el código del producto a eliminar: ");
                string codigoEliminar = Console.ReadLine();

                bool encontrado = false;
                for (int i = 0; i < 10; i++)
                {
                    if (inventario[i, 0] == codigoEliminar)
                    {
                        // Mostramos el producto antes de eliminar
                        Console.WriteLine("Eliminando: " + inventario[i, 1]);

                        // Limpiamos la fila dejándola disponible
                        inventario[i, 0] = "";
                        inventario[i, 1] = "";
                        inventario[i, 2] = "";

                        Console.WriteLine("Producto eliminado correctamente.");
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("No se encontró un producto con ese código.");
                }
            }
            else if (opcion == 5)
            {
                Console.WriteLine("Saliendo del sistema. ¡Hasta luego!");
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }

        } while (opcion != 5);
    }
}