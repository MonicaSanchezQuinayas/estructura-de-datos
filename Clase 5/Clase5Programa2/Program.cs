using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Clase5Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe  un  programa que llene  una  matriz  de  7  x  7.

        private int[,] mat;
        public void Cargar()
        {
            mat = new int[7, 7];

            for (int f = 0; f < 7; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    Console.Write("       digita el elemento [" + (f + 1) + "  " + (c + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }
        public void Imprimirvector()
        {
            Console.WriteLine(" ");
            Console.WriteLine("   La matriz resultante es");
            Console.WriteLine(" ");


            for (int f = 0; f < 7; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    Console.Write(" " + mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void sumarfilas()
        {
            //Calcular  la  suma  de  cada  fila y almacenarla en un vector
            for (int f = 0; f < 7; f++)
            {
                int sumarfilas = 0;

                for (int c = 0; c < 7; c++)
                {
                    sumarfilas = sumarfilas + mat[f, c];
                }
                Console.WriteLine("   La suma de la fila " + (f + 1) + " es: " + sumarfilas);
            }
            Console.WriteLine(" ");
        }

        public void sumarcolumna()
        {
            //Calcular  la  suma  de  cada columna y almacenarla en un vector
            for (int c = 0; c < 7; c++)
            {
                int sumarcolumnas = 0;

                for (int f = 0; f < 7; f++)
                {
                    sumarcolumnas = sumarcolumnas + mat[f, c];
                }

                Console.WriteLine(" La suma de la columna " + (c + 1) + " es: " + sumarcolumnas);
            }
        }

        static void Main(string[] args)
        {
            Program ma = new Program();
            ma.Cargar();
            ma.Imprimirvector();
            ma.sumarfilas();
            ma.sumarcolumna();
        }
    }
}
