using System;
using System.Collections.Generic;

class BibliotecaLibro
{
    static Dictionary<string, Dictionary<string, string>> libros = new Dictionary<string, Dictionary<string, string>>();
    static HashSet<string> codigos = new HashSet<string>();

    static void AgregarLibro()
    {
        Console.Write("Ingrese código del libro: ");
        string codigo = Console.ReadLine();

        if (codigos.Contains(codigo))
        {
            Console.WriteLine("El libro ya existe.");
        }
        else
        {
            Console.Write("Ingrese título: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese autor: ");
            string autor = Console.ReadLine();

            Console.Write("Ingrese categoría: ");
            string categoria = Console.ReadLine();

            libros[codigo] = new Dictionary<string, string>()
            {
                {"titulo", titulo},
                {"autor", autor},
                {"categoria", categoria}
            };

            codigos.Add(codigo);

            Console.WriteLine("Libro agregado correctamente.");
        }
    }

    static void ConsultarLibro()
    {
        Console.Write("Ingrese código a buscar: ");
        string codigo = Console.ReadLine();

        if (libros.ContainsKey(codigo))
        {
            var datos = libros[codigo];
            Console.WriteLine("Título: " + datos["titulo"]);
            Console.WriteLine("Autor: " + datos["autor"]);
            Console.WriteLine("Categoría: " + datos["categoria"]);
        }
        else
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }

    static void MostrarLibros()
    {
        foreach (var libro in libros)
        {
            Console.WriteLine("Código: " + libro.Key);
            Console.WriteLine("Título: " + libro.Value["titulo"]);
            Console.WriteLine("Autor: " + libro.Value["autor"]);
            Console.WriteLine("Categoría: " + libro.Value["categoria"]);
            Console.WriteLine("---------------------");
        }
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Agregar libro");
            Console.WriteLine("2. Consultar libro");
            Console.WriteLine("3. Mostrar todos");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            if (opcion == "1")
                AgregarLibro();
            else if (opcion == "2")
                ConsultarLibro();
            else if (opcion == "3")
                MostrarLibros();
            else if (opcion == "4")
                break;
        }
    }
}