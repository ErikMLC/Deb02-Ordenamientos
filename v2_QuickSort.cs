using System;
using System.Diagnostics;
using System.Text;

namespace Deb02_Ordenamientos;
class v2_QuickSort
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nOrdenamiento por QuickSort");
        Stopwatch time_quick = new Stopwatch();

        DateTime inicioEjecucion = DateTime.Now;
        Console.WriteLine("\nLa hora de inicio del programa es: " + DateTime.Now.ToLongTimeString());

        time_quick.Start();

        //int[] A = { 8, 74, 21, 42, 17, 67 };
        int[] A = { 12, 17, 16, 8, 67, 1, 4, 876, 21};
        Console.WriteLine("El arreglo desordenado es: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }
        Console.WriteLine(" ");
        Console.WriteLine($"{"Comienza Ord. por QuickSort: "}");
        OrdenamientoQuicksort(A, 0, A.Length - 1);

        Console.WriteLine("\nEl arreglo ordenado mediante QuickSort: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }

        DateTime finEjecucion = DateTime.Now;
        Console.WriteLine("\nLa hora de fin del programa es:" + DateTime.Now.ToLongTimeString());
        Console.WriteLine("\n" + "*** Time spent in the recursive method: " + time_quick.Elapsed.ToString() + " ***");
        time_quick.Stop();


    }

    static void OrdenamientoQuicksort(int[] A, int primero, int ultimo)
    {
        int i, j, central, pivote;
        central = (primero + ultimo) / 2;
        pivote = A[central];
        i = primero;
        j = ultimo;
        do
        {
            while (A[i] < pivote)
            {
                i++;
            }
            while (A[j] > pivote)
            {
                j--;
            }
            if (i <= j)
            {
                int tmp = A[i];
                A[i] = A[j];
                A[j] = tmp;
                i++;
                j--;
            }

        } while (i <= j);

        if (primero < j)
        {
            foreach (int k in A)
            {
                Console.Write(" " + k.ToString());
            }
            Console.WriteLine(" ");
            OrdenamientoQuicksort(A, primero, j);
        }
        if (i < ultimo)
        {
            foreach (int k in A)
            {
                Console.Write(" " + k.ToString());
            }
            Console.WriteLine(" ");
            OrdenamientoQuicksort(A, i, ultimo);
        }


    }
}
