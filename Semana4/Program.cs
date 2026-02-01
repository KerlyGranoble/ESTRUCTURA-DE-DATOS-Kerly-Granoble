using System;

namespace AgendaTelefonica
{
    // Registro del contacto
    struct Contacto
    {
        public string Nombre;
        public string Telefono;
    }

    class Agenda
    {
        private Contacto[] contactos;
        private int contador;

        public Agenda(int tamaño)
        {
            contactos = new Contacto[tamaño];
            contador = 0;
        }

        // Agregar contacto
        public void AgregarContacto()
        {
            if (contador < contactos.Length)
            {
                Console.Write("Ingrese nombre: ");
                contactos[contador].Nombre = Console.ReadLine();

                Console.Write("Ingrese teléfono: ");
                contactos[contador].Telefono = Console.ReadLine();

                contador++;
                Console.WriteLine("Contacto agregado correctamente.");
            }
            else
            {
                Console.WriteLine("La agenda está llena.");
            }
        }

        // Mostrar contactos
        public void MostrarContactos()
        {
            Console.WriteLine("\nLISTA DE CONTACTOS");

            if (contador == 0)
            {
                Console.WriteLine("No hay contactos registrados.");
            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"{i + 1}. {contactos[i].Nombre} - {contactos[i].Telefono}");
            }
        }

        // Buscar contacto
        public void BuscarContacto()
        {
            Console.Write("Ingrese el nombre a buscar: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < contador; i++)
            {
                if (contactos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contacto encontrado:");
                    Console.WriteLine("Teléfono: " + contactos[i].Telefono);
                    return;
                }
            }

            Console.WriteLine("Contacto no encontrado.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda(10);
            int opcion = 0;

            Console.WriteLine("Microsoft Windows - Ejecución desde CMD");
            Console.WriteLine("--------------------------------------");

            do
            {
                Console.WriteLine("\n===== AGENDA TELEFÓNICA =====");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar un número válido.");
                    opcion = 0;
                }

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        agenda.AgregarContacto();
                        break;

                    case 2:
                        agenda.MostrarContactos();
                        break;

                    case 3:
                        agenda.BuscarContacto();
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 4);
        }
    }
}
