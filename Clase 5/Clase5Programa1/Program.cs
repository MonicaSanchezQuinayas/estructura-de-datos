
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            private int[,] mat;
        public void vector()
        {
            // escribe un programa que almacene números en una matriz de 5x6
            mat = new int[5, 6];
            int sumar = 0;
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 6; c++)
                {
                    Console.Write("       digita el elemento [" + (f + 1) + "  " + (c + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);

                    sumar = sumar + mat[f, c];
                }
            }

            Console.Write(" ");
            Console.Write(" la suma de la matriz 5x6 es:  " + sumar);
        }
        static void Main(string[] args)
        {
            Program ma = new Program();
            ma.vector();
        }
    }
}
