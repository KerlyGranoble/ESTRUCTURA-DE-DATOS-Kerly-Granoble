using System;

namespace AgendaTelefonica
{
    // Estructura que guarda los datos del contacto
    struct Contacto
    {
        public string Nombre;
        public string Telefono;
    }

    class Agenda
    {
        // Vector de contactos
        private Contacto[] contactos;
        private int contador;

        public Agenda(int tamaño)
        {
            contactos = new Contacto[tamaño];
            contador = 0;
        }

        // Método para agregar un contacto
        public void AgregarContacto(string nombre, string telefono)
        {
            if (contador < contactos.Length)
            {
                contactos[contador].Nombre = nombre;
                contactos[contador].Telefono = telefono;
                contador++;
            }
            else
            {
                Console.WriteLine("La agenda está llena");
            }
        }

        // Método para mostrar todos los contactos
        public void MostrarContactos()
        {
            Console.WriteLine("LISTA DE CONTACTOS");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("Nombre: " + contactos[i].Nombre +
                                  " | Teléfono: " + contactos[i].Telefono);
            }
        }

        // Método para buscar un contacto
        public void BuscarContacto(string nombre)
        {
            for (int i = 0; i < contador; i++)
            {
                if (contactos[i].Nombre == nombre)
                {
                    Console.WriteLine("Contacto encontrado:");
                    Console.WriteLine("Teléfono: " + contactos[i].Telefono);
                    return;
                }
            }
            Console.WriteLine("Contacto no encontrado");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda(5);

            agenda.AgregarContacto("Kerly", "0992551165");
            agenda.AgregarContacto("Alberto", "095950226");
            agenda.AgregarContacto("Martha", "0997645390");

            agenda.MostrarContactos();

            Console.WriteLine();
            agenda.BuscarContacto("Kerly");

            Console.ReadKey();
        }
    }
}
