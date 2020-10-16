using System;
using System.Collections;
using System.Collections.Generic;

namespace Clase7Programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<float> colaC = new Queue<float>();
            colaC.Enqueue(100);
            colaC.Enqueue(200);
            colaC.Enqueue(300);
            colaC.Enqueue(400);
            colaC.Enqueue(500);

            foreach (int n in colaC)
                Console.Write("  {0} ", n);
            Console.WriteLine("");
            Console.WriteLine("______________________________");
            Console.WriteLine("");

            Stack nuevacola = new Stack();
            while (colaC.Count > 0)
                nuevacola.Push((int)colaC.Dequeue());

            while (colaC.Count > 0)
                colaC.Enqueue((int)nuevacola.Pop());

            foreach (int n in nuevacola)
                Console.Write("  {0} ", n);

            Console.WriteLine("");
            Console.WriteLine("______________________________");
            Console.WriteLine("");
        }
    }
}
