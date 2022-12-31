using System;
namespace Deb02_Ordenamientos;
class QuickSort
{
    static void Main7(string[] args)
    {
        Console.WriteLine("\nOrdenamiento por QuickSort");

        int[] A = { 8, 74, 21, 42, 17, 67 };
        Console.WriteLine("El arreglo desordenado es: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }
        OrdenamientoQuicksort(A, 0, A.Length - 1);

        Console.WriteLine("\nEl arreglo ordenado mediante QuickSort: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }


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
            OrdenamientoQuicksort(A, primero, j);
        }
        if (i < ultimo)
        {
            OrdenamientoQuicksort(A, i, ultimo);
        }


    }
}
