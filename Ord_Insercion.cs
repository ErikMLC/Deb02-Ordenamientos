using System;
namespace Deb02_Ordenamientos;
class Ord_Insercion
{
    static void Main5(string[] args)
    {
        Console.WriteLine("\nOrdenamiento por Inserción");
        int[] A = { 24, 4, 11, 32, 71, 27 };
        Console.WriteLine("El arreglo desordenado es: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }
        InsercionLineal(A, 6);
        Console.WriteLine("\nEl arreglo ordenado por inserción lineal: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }


    }

    static int InsercionLineal(int[] A, int n)
    {
        bool encontrado;
        int auxiliar, j;
        for (int i = 1; i < n; i++)
        {
            auxiliar = A[i];                        //A[0], A[1], .... , A[n-1] --> esta ordenado 
            j = i - 1;
            encontrado = false;
            while ((j >= 0) && !encontrado)
            {
                if (A[j] > auxiliar)               // se mueve el dato hacia la derecha para la inserccion                     
                {
                    A[j + 1] = A[j];
                    j--;
                }
                else
                {
                    encontrado = true;
                }
            }
            A[j + 1] = auxiliar;
        }
        return -1;

    }
}
