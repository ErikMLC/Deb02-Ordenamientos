using System;
using System.Diagnostics;
using System.Text;

namespace Deb02_Ordenamientos;

class v2_ordInsercion
{
    static void Main6(string[] args)
    {
        Console.WriteLine("\nOrdenamiento por Inserción");
        Stopwatch time_insercion = new Stopwatch();

        DateTime inicioEjecucion = DateTime.Now;
        Console.WriteLine("\nLa hora de inicio del programa es: " + DateTime.Now.ToLongTimeString());

        time_insercion.Start();

        int[] A = { 24, 4, 11, 32, 71, 27 };

        Console.WriteLine("El arreglo desordenado es: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }
        Console.WriteLine(" ");
        Console.WriteLine($"{"Comienza Ord. por insercion: "}");

        InsercionLineal(A, 6);
        Console.WriteLine("\nEl arreglo ordenado por inserción lineal: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }

        DateTime finEjecucion = DateTime.Now;
        Console.WriteLine("\nLa hora de fin del programa es:" + DateTime.Now.ToLongTimeString());
        Console.WriteLine("\n" + "*** Time spent in the recursive method: " + time_insercion.Elapsed.ToString() + " ***");
        time_insercion.Stop();

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

            for (int k = 0; k < n; k++)
            {
                Console.Write(A[k] + " ");

            }
            Console.WriteLine(" ");
        }
        return -1;

    }
}
