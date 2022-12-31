using System;
using System.Text;
using System.Diagnostics;

namespace Deb02_Ordenamientos;
class v2_ordSeleccion
{
    static void Main4(string[] args)
    {
        Console.WriteLine("\nOrdenamiento por Seleccion");
        Stopwatch time_seleccion = new Stopwatch();

        DateTime inicioEjecucion = DateTime.Now;
        Console.WriteLine("\nLa hora de inicio del programa es: " + DateTime.Now.ToLongTimeString());

        time_seleccion.Start();
        int[] A = { 90, 54, 31, 12, 7, 17 };
        Console.WriteLine("El arreglo desordenado es: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }
        Console.WriteLine(" ");

        Console.WriteLine($"{"Comienza Ord. por seleccion: "}{"Cambio",15}{"Pasada",12}");
        Seleccion(A, 6);
        Console.WriteLine("\nEl arreglo ordenado por seleccion es: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }

        DateTime finEjecucion = DateTime.Now;
        Console.WriteLine("\nLa hora de fin del programa es:" + DateTime.Now.ToLongTimeString());
        Console.WriteLine("\n" + "*** Time spent in the recursive method: " + time_seleccion.Elapsed.ToString() + " ***");
        time_seleccion.Stop();


    }

    static int Seleccion(int[] A, int n)
    {
        int indiceMenor;
        int auxiliar;
        for (int i = 0; i < n - 1; i++)
        {
            indiceMenor = i;        //posicion menor 
            for (int j = i + 1; j < n; j++)
            {
                if (A[j] < A[indiceMenor])
                {
                    indiceMenor = j;   //nueva posicion del menor 
                }

            }
            auxiliar = A[indiceMenor];   //intercambia posiciones
            A[indiceMenor] = A[i];
            A[i] = auxiliar;

            for (int k = 0; k < n; k++)
            {
                Console.Write(A[k] + " ");

            }
            Console.WriteLine($"{A[indiceMenor],25}{A[i],3}{i,10}");

        }
        return -1;

    }
}
