using System;
using System.Collections;

namespace Clase7Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue c1 = new Queue();

            c1.Enqueue(10);
            c1.Enqueue(20);
            c1.Enqueue(30);
            c1.Enqueue(40);
            c1.Enqueue(50);
            c1.Enqueue(60);
            c1.Enqueue(70);

            foreach (int n in c1)
                Console.Write("  {0} ", n);
            Console.WriteLine("");
            Console.WriteLine("______________________________");
            Console.WriteLine("");

            Stack nuevacola = new Stack();
            while (c1.Count > 0)
                nuevacola.Push((int)c1.Dequeue());

            while (c1.Count > 0)
                c1.Enqueue((int)nuevacola.Pop());

            foreach (int n in nuevacola)
                Console.Write("  {0} ", n);

            Console.WriteLine("");
            Console.WriteLine("______________________________");
            Console.WriteLine("");
        }
    }
}
