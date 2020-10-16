using System;
using System.Collections;

namespace Clase6Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aux = new int[5];
            // recibir pila1 Y pila2

            int[] mipila1 = { 2, 3, 4, 5, 6 };
            int[] mipila2 = { 7, 0, 9, 8, 10 };

            Console.WriteLine("");
            Console.WriteLine("primera lista: {0}", string.Join(" , ", mipila1));
            Console.WriteLine("segunda lista: {0}", string.Join(" , ", mipila2));
            Console.WriteLine("______________________________________");


            int[] result = new int[mipila1.Length + mipila2.Length];
            for (int i = 0; i < mipila1.Length; i++)
            {
                //intercambiar valores 
                aux[i] = mipila1[i];
                mipila1[i] = mipila2[i];
                mipila2[i] = aux[i];
            }
            Console.WriteLine("");
            Console.WriteLine("valores intercambiados");
            Console.WriteLine("primera lista: {0}", string.Join(" , ", mipila1));
            Console.WriteLine("segunda lista: {0}", string.Join(" , ", mipila2));
            Console.WriteLine("______________________________________");

            //la pila1 debe tener los valores de la pila2 con sus propios valores

            for (int i = 0; i < mipila1.Length; i++)
            {
                result[i] = mipila1[i];
            }

            for (int i = 0; i < mipila2.Length; i++)
            {
                result[i + mipila1.Length] = mipila2[i];

                Array.Reverse(result);
            }

            Console.WriteLine("");
            Console.WriteLine("Resultado: {0}", string.Join(", ", result));
        }
    }
}
