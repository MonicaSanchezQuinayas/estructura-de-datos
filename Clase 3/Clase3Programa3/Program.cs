using System;

namespace Clase3Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Digita la tabla hasta la que deseas llegar");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                    Console.WriteLine(i + "x" + j + "= " + (i * j));
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
