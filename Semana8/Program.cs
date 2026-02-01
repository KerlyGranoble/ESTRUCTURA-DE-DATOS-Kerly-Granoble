using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ParqueDiversiones
{
    // Clase Persona
    class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
    }

    // Clase Atracción
    class Atraccion
    {
        private Queue<Persona> cola;
        private int capacidadMaxima;

        public Atraccion(int capacidad)
        {
            capacidadMaxima = capacidad;
            cola = new Queue<Persona>();
        }

        // Agregar persona a la cola
        public void AgregarPersona(string nombre)
        {
            if (cola.Count < capacidadMaxima)
            {
                cola.Enqueue(new Persona(nombre));
                Console.WriteLine($"Persona {nombre} llegó a la fila.");
            }
            else
            {
                Console.WriteLine("Todos los asientos están vendidos.");
            }
        }

        // Asignar asientos en orden FIFO (CORRECTO)
        public void AsignarAsientos()
        {
            Console.WriteLine("\nAsignación de asientos (orden real de subida):");
            int asiento = 1;

            while (cola.Count > 0)
            {
                Persona p = cola.Dequeue();
                Console.WriteLine($"Asiento {asiento}: {p.Nombre}");
                asiento++;
            }
        }

        // Reportería: mostrar desde el ÚLTIMO que llegó
        public void MostrarColaDesdeUltimo()
        {
            Console.WriteLine("\nCola de espera (último en llegar → primero en llegar):");

            if (cola.Count == 0)
            {
                Console.WriteLine("No hay personas en la cola.");
                return;
            }

            // Convertimos la cola en lista para recorrerla al revés
            List<Persona> lista = new List<Persona>(cola);

            for (int i = lista.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(lista[i].Nombre);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Atraccion atraccion = new Atraccion(30);
            Stopwatch tiempo = new Stopwatch();

            tiempo.Start();

            // Simulación de llegada
            for (int i = 1; i <= 30; i++)
            {
                atraccion.AgregarPersona("Persona " + i);
            }

            // Reportería solicitada
            atraccion.MostrarColaDesdeUltimo();

            // Asignación real (FIFO)
            atraccion.AsignarAsientos();

            tiempo.Stop();

            Console.WriteLine($"\nTiempo de ejecución: {tiempo.ElapsedMilliseconds} ms");
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
