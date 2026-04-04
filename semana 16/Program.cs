using System;

class Nodo
{
    public int valor;
    public Nodo? izquierda, derecha;

    public Nodo(int v)
    {
        valor = v;
        izquierda = null;
        derecha = null;
    }
}

class ArbolBinario
{
    public Nodo? raiz;

    public Nodo Insertar(Nodo? nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.valor)
            nodo.izquierda = Insertar(nodo.izquierda, valor);
        else if (valor > nodo.valor)
            nodo.derecha = Insertar(nodo.derecha, valor);

        return nodo;
    }

    public bool Buscar(Nodo? nodo, int valor)
    {
        if (nodo == null) return false;

        if (nodo.valor == valor) return true;

        if (valor < nodo.valor)
            return Buscar(nodo.izquierda, valor);
        else
            return Buscar(nodo.derecha, valor);
    }

    public void InOrden(Nodo? nodo)
    {
        if (nodo != null)
        {
            InOrden(nodo.izquierda);
            Console.Write(nodo.valor + " ");
            InOrden(nodo.derecha);
        }
    }
}

class Programa
{
    static void Main()
    {
        ArbolBinario arbol = new ArbolBinario();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ =====");
            Console.WriteLine("1. Insertar número");
            Console.WriteLine("2. Buscar número");
            Console.WriteLine("3. Mostrar árbol (InOrden)");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese número: ");
                    int numInsertar = int.Parse(Console.ReadLine());
                    arbol.raiz = arbol.Insertar(arbol.raiz, numInsertar);
                    Console.WriteLine("Número insertado.");
                    break;

                case 2:
                    Console.Write("Ingrese número a buscar: ");
                    int numBuscar = int.Parse(Console.ReadLine());

                    if (arbol.Buscar(arbol.raiz, numBuscar))
                        Console.WriteLine("El número SI existe.");
                    else
                        Console.WriteLine("El número NO existe.");
                    break;

                case 3:
                    Console.WriteLine("Recorrido en orden:");
                    arbol.InOrden(arbol.raiz);
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 4);
    }
}