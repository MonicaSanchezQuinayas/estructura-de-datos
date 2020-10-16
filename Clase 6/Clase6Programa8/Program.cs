using System;
using System.Collections;

namespace Clase6Programa8
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList pilaP = new ArrayList();

            // valores de la lista 
            string valor = "";
            int numero = 1;

            Console.WriteLine("            ***** digita un cero para cerrar la lista  ******  ");
            Console.WriteLine("");

            while (numero != 0)
            {
                Console.WriteLine("Por favor, introduce un número:  ");
                valor = Console.ReadLine();
                numero = Convert.ToInt32(valor);
                pilaP.Add(numero);
            }

            //organizamos la fila

            pilaP.Sort();
            foreach (int n in pilaP)
                Console.WriteLine(n);
            Console.WriteLine("\n—————————————");

            //agragamos los valores de pilaP a pilaI

            ArrayList pilaI = new ArrayList();
            pilaI = pilaP;

            //invertimos la pilaI

            pilaI.Reverse();
            foreach (int n in pilaI)
                Console.WriteLine(n);
            Console.WriteLine("\n—————————————");

            //Limpiamos el array filaP
            pilaP.Clear();
        }

        static void imprime(ArrayList arreglo)
        {
            foreach (int n in arreglo)
                Console.Write("  {0},", n);
            Console.WriteLine();
        }
    }
}
