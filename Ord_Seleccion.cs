using System;
namespace Deb02_Ordenamientos;
class Ord_Seleccion
{
    static void Main3(string[] args)
    {
        int[] A = { 90, 54, 31, 12, 7, 17 };
        Console.WriteLine("El arreglo desordenado es: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }
        Seleccion(A, 6);
        Console.WriteLine("\nEl arreglo ordenado por seleccion es: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}" + "  ");
        }


    }

    static int Seleccion(int[] A, int n)
    {
        int indiceMenor;
        int auxiliar;
        for (int i = 0; i < n - 1; i++)                        
        {
            indiceMenor= i;        //posicion menor 
            for (int j = i +1 ; j < n; j++)                 
            {
                if (A[j] < A[indiceMenor])                     
                {
                    indiceMenor= j;   //nueva posicion del menor 
                }

            }
            auxiliar= A[indiceMenor];   //intercambia posiciones
            A[indiceMenor]= A[i];
            A[i]= auxiliar;

        }
        return -1;

    }
}
