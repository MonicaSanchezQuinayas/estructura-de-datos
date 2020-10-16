using System;
using System.Collections;


namespace Clase7Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue c1 = new Queue();


            c1.Enqueue(1);
            c1.Enqueue(2);
            c1.Enqueue(3);
            c1.Enqueue(4);
            c1.Enqueue(5);
            c1.Enqueue(6);
            c1.Enqueue(7);


            foreach (int n in c1)
                Console.Write("  {0} ", n);
            Console.WriteLine("");
            Console.WriteLine("______________________________");
            Console.WriteLine("");

            //Lo pasamos a una pila 
            ArrayList pila = new ArrayList();
            while (c1.Count > 0)
                pila.Add((int)c1.Dequeue());

            //Mantenemos el orden 
            foreach (int n in pila)
                Console.Write("  {0} ", n);
            Console.WriteLine("");
            Console.WriteLine("______________________________");
            Console.WriteLine("");
        }
    }
}
