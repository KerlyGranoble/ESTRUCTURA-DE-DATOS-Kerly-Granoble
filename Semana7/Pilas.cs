using System;
using System.Collections.Generic;

class Program
{
    // ---------------- PARTE 1 Balanceado----------------
    static bool EstaBalanceado(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '{' || c == '[')
                pila.Push(c);

            if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                    return false;

                char ultimo = pila.Pop();

                if ((c == ')' && ultimo != '(') ||
                    (c == '}' && ultimo != '{') ||
                    (c == ']' && ultimo != '['))
                    return false;
            }
        }

        return pila.Count == 0;
    }

    // ---------------- PARTE 2 Torres de Hanoi----------------
    static void MoverDiscos(
        int n,
        Stack<int> origen,
        Stack<int> destino,
        Stack<int> auxiliar,
        string o,
        string d,
        string a)
    {
        if (n > 0)
        {
            MoverDiscos(n - 1, origen, auxiliar, destino, o, a, d);

            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {o} a {d}");

            MoverDiscos(n - 1, auxiliar, destino, origen, a, d, o);
        }
    }

    static void Main()
    {
        Console.WriteLine("MENU");
        Console.WriteLine("1. Verificar paréntesis");
        Console.WriteLine("2. Torres de Hanoi");
        Console.Write("Elige una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            string formula = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
            if (EstaBalanceado(formula))
                Console.WriteLine("Fórmula balanceada ");
            else
                Console.WriteLine("No está balanceada ");
        }
        else if (opcion == 2)
        {
            Stack<int> A = new Stack<int>();
            Stack<int> B = new Stack<int>();
            Stack<int> C = new Stack<int>();

            int discos = 3;

            for (int i = discos; i >= 1; i--)
                A.Push(i);

            MoverDiscos(discos, A, C, B, "Torre A", "Torre C", "Torre B");
        }
    }
}
