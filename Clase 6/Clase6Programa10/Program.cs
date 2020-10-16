using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Clase6Programa10
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear la pila y ponerle valores 

            Stack miPila = new Stack();

            object[] mipila = new object[] { 5, 4, 3, 2, 1 };

            //crear un copia que no pueda ser modificada 

            object[] myarray1;

            myarray1 = mipila.Clone() as object[];

            foreach (int n in myarray1)
                Console.Write("  {0}", n);
            Console.WriteLine("");
            Console.WriteLine("————");
        }
    }
}
