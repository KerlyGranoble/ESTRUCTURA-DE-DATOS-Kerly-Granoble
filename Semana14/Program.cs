using System;

class Nodo
{
    public int Valor;
    public Nodo Izquierdo;
    public Nodo Derecho;

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}

class BST
{
    public Nodo raiz;

    // Insertar
    public Nodo Insertar(Nodo nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.Valor)
            nodo.Izquierdo = Insertar(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = Insertar(nodo.Derecho, valor);

        return nodo;
    }

    // Buscar
    public bool Buscar(Nodo nodo, int valor)
    {
        if (nodo == null)
            return false;

        if (valor == nodo.Valor)
            return true;
        else if (valor < nodo.Valor)
            return Buscar(nodo.Izquierdo, valor);
        else
            return Buscar(nodo.Derecho, valor);
    }

    // Mínimo
    public Nodo Minimo(Nodo nodo)
    {
        while (nodo.Izquierdo != null)
            nodo = nodo.Izquierdo;
        return nodo;
    }

    // Eliminar
    public Nodo Eliminar(Nodo nodo, int valor)
    {
        if (nodo == null) return nodo;

        if (valor < nodo.Valor)
            nodo.Izquierdo = Eliminar(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = Eliminar(nodo.Derecho, valor);
        else
        {
            if (nodo.Izquierdo == null)
                return nodo.Derecho;
            else if (nodo.Derecho == null)
                return nodo.Izquierdo;

            Nodo temp = Minimo(nodo.Derecho);
            nodo.Valor = temp.Valor;
            nodo.Derecho = Eliminar(nodo.Derecho, temp.Valor);
        }
        return nodo;
    }

    // Recorridos
    public void Inorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Inorden(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            Inorden(nodo.Derecho);
        }
    }

    public void Preorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.Valor + " ");
            Preorden(nodo.Izquierdo);
            Preorden(nodo.Derecho);
        }
    }

    public void Postorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Postorden(nodo.Izquierdo);
            Postorden(nodo.Derecho);
            Console.Write(nodo.Valor + " ");
        }
    }

    // Máximo
    public int Maximo(Nodo nodo)
    {
        while (nodo.Derecho != null)
            nodo = nodo.Derecho;
        return nodo.Valor;
    }

    // Altura
    public int Altura(Nodo nodo)
    {
        if (nodo == null) return -1;

        int izq = Altura(nodo.Izquierdo);
        int der = Altura(nodo.Derecho);

        return Math.Max(izq, der) + 1;
    }

    // Limpiar árbol
    public void Limpiar()
    {
        raiz = null;
    }
}

class Program
{
    static void Main()
    {
        BST arbol = new BST();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n--- MENU BST ---");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Recorridos");
            Console.WriteLine("5. Minimo, Maximo y Altura");
            Console.WriteLine("6. Limpiar árbol");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.raiz = arbol.Insertar(arbol.raiz, valor);
                    break;

                case 2:
                    Console.Write("Buscar valor: ");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(arbol.raiz, valor) ? "Existe" : "No existe");
                    break;

                case 3:
                    Console.Write("Eliminar valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.raiz = arbol.Eliminar(arbol.raiz, valor);
                    break;

                case 4:
                    Console.WriteLine("Inorden:");
                    arbol.Inorden(arbol.raiz);
                    Console.WriteLine("\nPreorden:");
                    arbol.Preorden(arbol.raiz);
                    Console.WriteLine("\nPostorden:");
                    arbol.Postorden(arbol.raiz);
                    Console.WriteLine();
                    break;

                case 5:
                    if (arbol.raiz != null)
                    {
                        Console.WriteLine("Minimo: " + arbol.Minimo(arbol.raiz).Valor);
                        Console.WriteLine("Maximo: " + arbol.Maximo(arbol.raiz));
                        Console.WriteLine("Altura: " + arbol.Altura(arbol.raiz));
                    }
                    else
                    {
                        Console.WriteLine("Árbol vacío");
                    }
                    break;

                case 6:
                    arbol.Limpiar();
                    Console.WriteLine("Árbol limpiado");
                    break;
            }

        } while (opcion != 0);
    }
}