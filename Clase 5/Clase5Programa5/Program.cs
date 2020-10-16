using System;

namespace Clase5Programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            int h, i, j;
            string opc;
            string[,] m = new string[50, 50];
            string[] v = new string[50];
            h = 1;
            do
            {
                Console.WriteLine("Digita el numero de filas:");
                a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Digita el numero de columnas:");
                b = Double.Parse(Console.ReadLine());
                for (i = 1; i <= a; i++)
                {
                    for (j = 1; j <= b; j++)
                    {
                        Console.WriteLine("Digita la posicion: " + i + "," + j);
                        m[i, j] = Console.ReadLine();
                        v[h] = m[i, j];
                        h = h + 1;
                    }
                }
                for (j = 1; j <= a; j++)
                {
                    for (i = 1; i <= b; i++)
                    {
                        Console.Write(m[i, j] + " ");
                    }
                    Console.WriteLine("");
                }
                c = a * b;
                Console.WriteLine(c);
                Console.WriteLine("El vector resultante es: ");
                for (i = 1; i <= c; i++)
                {
                    Console.WriteLine(v[i]);
                }
                opc = Console.ReadLine();
            } while (!(opc.Equals("NO") || opc.Equals("no")));
        }
    }
}
