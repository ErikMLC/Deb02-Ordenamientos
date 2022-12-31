using System;
using System.Text;
using System.Diagnostics;

namespace Deb02_Ordenamientos;
class v2_BubleSort
{
    static void Main2(string[] args)
    {
        Console.WriteLine("\nOrdenamiento por Seleccion");
        Stopwatch time_bubleSort = new Stopwatch(); 

        DateTime inicioEjecucion= DateTime.Now;
        Console.WriteLine("\nLa hora de inicio del programa es: "+ DateTime.Now.ToLongTimeString());

        time_bubleSort.Start();
        Console.WriteLine("El arreglo desordenado es: ");
        int[] A = { 12, 54, 32, 17, 50 };
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }

        Console.WriteLine("");
        Console.WriteLine($"{"Comienza Burbuja: "}{"Cambio",15}{"Pasada",12}");
        Burbuja(A, 5);
        Console.WriteLine("\n El arreglo ordenado es: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }

        DateTime finEjecucion= DateTime.Now;
        Console.WriteLine("\nLa hora de fin del programa es:"+ DateTime.Now.ToLongTimeString());
        Console.WriteLine("\n"+ "*** Time spent in the recursive method: "+ time_bubleSort.Elapsed.ToString() + " ***");
        time_bubleSort.Stop();



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
                for (int k = 0; k < n; k++)
                {
                    Console.Write(A[k] + " ");

                }
                Console.WriteLine($"{A[j],15}{A[j + 1],3}{i,10}");

            }


        }
        return -1;

    }
}
