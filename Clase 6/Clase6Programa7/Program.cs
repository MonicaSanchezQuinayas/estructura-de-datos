using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Clase6Programa7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList PilaP = new ArrayList();

            //Escriba una rutina que reciba una PilaP

            string valor = "";
            int numero = 1;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("      ***** digita un cero para cerrar la lista  ******  ");
            Console.WriteLine("");

            while (numero != 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Por favor, introduce un número:  ");
                valor = Console.ReadLine();
                numero = Convert.ToInt32(valor);
                PilaP.Add(numero);
            }

            Console.WriteLine("");
            foreach (int n in PilaP)
                Console.WriteLine(n);
            Console.WriteLine("\n—————————————");


            //agregamos los valor de la pilaP a la nuevapila
            ArrayList nuevaPila = new ArrayList();
            nuevaPila = PilaP;

            // imprimimos la nuevapila
            Console.WriteLine("");
            {
                foreach (int m in nuevaPila)
                    Console.WriteLine(m);
                Console.WriteLine("\n—————————————");
            }

            //limpiar la pilaP 
            PilaP.Clear();

            Console.WriteLine("");
            Console.WriteLine("   *******los valores fueron eliminados******* ");

            foreach (int n in PilaP)
                Console.WriteLine(n);
            Console.WriteLine("\n—————————————");

        }
    }
}
