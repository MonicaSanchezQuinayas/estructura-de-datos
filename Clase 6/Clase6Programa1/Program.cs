using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace Clase6Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList miPila = new ArrayList();

            //escriba un programa que inserte valoress ordenadamente en una lista 

            string valor = "";
            int numero = 1;


            while (numero != 0)
            {
                Console.WriteLine("Por favor, introduce un número:  ");
                valor = Console.ReadLine();
                numero = Convert.ToInt32(valor);
                miPila.Add(numero);
            }

            // el programa debe leer una secuencia de números enteros de la entrada hasta que se ingrese el número cero
            Console.WriteLine("la lista  tiene {0} elementos", miPila.Count);
            miPila.Sort();
            foreach (int n in miPila)
                Console.Write("  {0}", n);
            Console.WriteLine("");
        }
    }
}
