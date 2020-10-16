using System;
using System.Collections;

namespace Clase6Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine();

            int[] list1 = { 1, 3, 5 };
            int[] list2 = { 2, 4 };

            Console.WriteLine("primera lista: {0}", string.Join(" , ", list1));
            Console.WriteLine("segunda lista: {0}", string.Join(" , ", list2));
            Console.WriteLine("");


            int[] result = new int[list1.Length + list2.Length];

            for (int i = 0; i < list1.Length; i++)
            {
                result[i] = list1[i];
            }

            for (int i = 0; i < list2.Length; i++)
            {
                result[i + list1.Length] = list2[i];
            }

            Console.WriteLine("Resultado: {0}", string.Join(", ", result));
        }
    }
}
