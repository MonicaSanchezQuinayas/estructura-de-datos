using System;
using System.Collections.Generic;
using System.Text;
namespace Clase4Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
             //Modifica el ejercicio anterior para que insertes los valores numéricos con leer mediante un bucle y los muestre por pantalla.

        private int[] numeros;
        public void desarrollo()
        {
            int n = 0;
            string valor = "";
            numeros = new int[6];
            for (n = 1; n < numeros.Length; n++)
            {
                Console.WriteLine("Ingrese el valor del número " + n + ": ");
                valor = Console.ReadLine();
                numeros[n] = int.Parse(valor);
            }
            for (n = 1; n < numeros.Length; n++)
            {
                Console.WriteLine("el " + n + " número digitado es: " + numeros[n]);

            }

        }

        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.desarrollo();
        }
    }
}
