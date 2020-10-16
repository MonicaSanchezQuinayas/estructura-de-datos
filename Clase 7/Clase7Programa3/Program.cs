using System;
using System.Collections;

namespace Clase7Programa3
{
    class Program
    {

        public static void ConcatenarColas(Queue c1, Queue c2, Queue pax)
        {
            try
            {
                while (c1.Count > 0)
                    pax.Enqueue((float)c1.Dequeue());
                while (c2.Count > 0)
                    pax.Enqueue((float)c1.Dequeue());
                Console.WriteLine("Numero: " + c2.Dequeue());

            }
            catch (InvalidOperationException e) { Console.WriteLine("" + e.Message); }
        }
        public static void Main()
        {
            Queue c1 = new Queue();
            Queue c2 = new Queue();
            Queue pax = new Queue();

            c1.Enqueue(1);
            c1.Enqueue(2);
            c1.Enqueue(3);
            c1.Enqueue(4);
            c1.Enqueue(5);

            c2.Enqueue(6);
            c2.Enqueue(7);
            c2.Enqueue(8);
            c2.Enqueue(9);
            c2.Enqueue(10);

            ConcatenarColas(c1, c2, pax);
            Console.WriteLine("Colas concatenadas");
        }
    }
}
