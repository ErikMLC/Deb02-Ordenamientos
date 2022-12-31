using System;
namespace Deb02_Ordenamientos;
class BubleSort
{
    static void Main1(string[] args)
    {
        int[] A = { 12, 98, 43, 35, 10, 17 };
        Console.WriteLine("El arreglo desordenado es: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }
        Burbuja(A, 6);
        Console.WriteLine("\n El arreglo ordenado es: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }


    }

    static int Burbuja(int[] A, int n)
    {

        int auxiliar;
        for (int i = 0; i < n - 1; i++)                        //n-1 pasadas
        {
            for (int j = 0; j < n - 1 - i; j++)                 //burbujeo de datos
            {
                if (A[j] > A[j + 1])                       //comparacion elementos 
                {
                    auxiliar = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = auxiliar;

                }

            }
            

        }
        return -1;

    }
}
