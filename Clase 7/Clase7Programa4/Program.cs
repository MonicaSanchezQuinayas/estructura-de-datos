using System;

using System.Collections;

namespace Clase7Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba una rutina que reciba dos colas C1 y C2

            Queue c1 = new Queue();

            c1.Enqueue(1);
            c1.Enqueue(2);
            c1.Enqueue(3);
            c1.Enqueue(4);
            c1.Enqueue(5);


            foreach (int n in c1)
                Console.Write("  {0} ", n);

            Console.WriteLine("");
            Console.WriteLine("___________________");
            Console.WriteLine("");

            Queue c2 = new Queue();

            c2.Enqueue(6);
            c2.Enqueue(7);
            c2.Enqueue(8);
            c2.Enqueue(9);
            c2.Enqueue(10);

            foreach (int n in c2)
                Console.Write("  {0} ", n);

            Console.WriteLine("");
            Console.WriteLine("___________________");
            Console.WriteLine("");

            //intercambiar sus elementos
            Queue c3 = new Queue();
            while (c1.Count > 0)
                c3.Enqueue((int)c1.Dequeue());

            //C1 tendra los elementos de la cola c2 y esta a su vez tendra los elementos de la c1
            while (c2.Count > 0)
                c1.Enqueue((int)c2.Dequeue());

            while (c3.Count > 0)
                c2.Enqueue((int)c3.Dequeue());

            Console.WriteLine("colas intercambiadas");
            Console.WriteLine("");
            foreach (int n in c1)
                Console.Write("  {0} ", n);
            Console.WriteLine("\n __________________");
            Console.WriteLine("");
            foreach (int n in c2)
                Console.Write("  {0} ", n);
            Console.WriteLine("\n __________________");
        }
    }
}
