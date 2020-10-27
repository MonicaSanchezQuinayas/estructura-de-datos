using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Clase7Programa6
{
    class Program
    {
        static void Main(string[] args)
        {
            //escriba una rutina que reciba una cola c de numeros flotantes

            Queue<float> colaC = new Queue<float>();
            colaC.Enqueue(34);
            colaC.Enqueue(44);
            colaC.Enqueue(54);
            colaC.Enqueue(64);
            colaC.Enqueue(74);

            foreach (int n in colaC)
                Console.Write("  {0} ", n);
            Console.WriteLine("");
            Console.WriteLine("______________________________");
            Console.WriteLine("");

            //devuelva en una pila 
            ArrayList pila = new ArrayList();
            while (colaC.Count > 0)
                pila.Add((int)colaC.Dequeue());

            //manteniendo el orden de salida
            foreach (int n in pila)
                Console.Write("  {0} ", n);
            Console.WriteLine("");
            Console.WriteLine("______________________________");
            Console.WriteLine("");
        }
    }
}
