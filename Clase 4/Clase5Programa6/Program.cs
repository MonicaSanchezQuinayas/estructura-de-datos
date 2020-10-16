using System;

namespace Clase5Programa6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int tamaño;
            tamaño = 5;
            string[] arreglo1 = new string[tamaño];
            string[] arreglo2 = new string[tamaño];
            string[] arreglo3 = new string[tamaño];

            for (i = 0; i <= tamaño - 1; i++)
            {
                Console.WriteLine("Digita el valor del arreglo 1 en la posicion " + i);
                arreglo1[i] = Console.ReadLine();
                Console.WriteLine("Digita el valor del arreglo 2 en la posicion " + i);
                arreglo2[i] = Console.ReadLine();
                arreglo3[i] = arreglo1[i] + arreglo2[i];
            }

            for (i = 0; i <= tamaño - 1; i++)
            {
                Console.WriteLine(arreglo1[i] + " + " + arreglo2[i] + " = " + arreglo3[i]);
                Console.ReadLine();
            }
        }
    }
}
