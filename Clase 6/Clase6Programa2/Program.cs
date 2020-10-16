using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Clase6Programa2
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList datos = new ArrayList();

            // valores de la lista 
            datos.Add(2);
            datos.Add(10);
            datos.Add(8);
            datos.Add(6);
            datos.Add(9);

            int cuadrado = 0;

            //mostrar los valores de la lista
            Console.WriteLine("Tenemos inicialmente los datos:");
            imprime(datos);
            Console.WriteLine("\n—————————————");

            //suma y sacar el cuadrado de los valores de la lista
            foreach (int i in datos)
                cuadrado = cuadrado + (i * i);
            Console.WriteLine(" la suma de los elementos al cuadrado es: " + cuadrado);
        }

        static void imprime(ArrayList arreglo)
        {
            foreach (int n in arreglo)
                Console.Write("  {0},", n);
            Console.WriteLine();
        }

    }

}
