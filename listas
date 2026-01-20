using System;

namespace ListaSimple
{
    // Nodo de la lista enlazada
    class Nodo
    {
        public int dato;
        public Nodo? siguiente; // Puede ser null

        public Nodo(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
    }

    // Lista enlazada
    class ListaEnlazada
    {
        private Nodo? cabeza; // Puede ser null

        public void Agregar(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;

                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }

                actual.siguiente = nuevo;
            }
        }

        public int ContarElementos()
        {
            int contador = 0;
            Nodo? actual = cabeza;

            while (actual != null)
            {
                contador++;
                actual = actual.siguiente;
            }

            return contador;
        }
    }

    class Program
    {
        static void Main()
        {
            ListaEnlazada lista = new ListaEnlazada();

            lista.Agregar(10);
            lista.Agregar(20);
            lista.Agregar(30);

            Console.WriteLine("Cantidad de elementos: " + lista.ContarElementos());
        }
    }
}
