using System;

namespace Clase5Programa6
{
    class Program
    {
        static void Main(string[] args)
        {
             //escribe un programa que llene una matriz 5x6

        private int[,] mat;

        public void vector()
        {

            mat = new int[5, 6];

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 6; c++)
                {
                    Console.Write("       Ingrese el elemento [" + (f + 1) + "  " + (c + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("   La matriz resultante es");
            Console.WriteLine(" ");

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 6; c++)
                {
                    Console.Write("    " + mat[f, c] + " ");
                }
                Console.WriteLine();
            }

        }


        public void numerosalamcenados()
        {
            int sumaceros = mat[0, 0];
            int xx = 0;

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 6; c++)
                {
                    if (mat[f, c] == 0)
                    {
                        sumaceros = sumaceros + 1;
                        xx = sumaceros - 1;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("la cantidad de ceros es: " + xx);

            int sumapositivos = mat[0, 0];
            int sumanegativos = mat[0, 0];
            int zz = 0;
            int vv = 0;

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 6; c++)
                {
                    if (mat[f, c] > 0)
                    {
                        sumapositivos = (sumapositivos + 1);
                        zz = sumapositivos - 1;

                    }
                    else
                if (mat[f, c] < 0)
                    {
                        sumanegativos = (sumanegativos + 1);
                        vv = sumanegativos - 1;
                    }
                }
            }


            Console.WriteLine("la cantidad de números postivos es: " + zz);
            Console.WriteLine("la cantidad de números negativos es: " + vv);
        }

        static void Main(string[] args)
        {
            Program ma = new Program();
            ma.vector();
            ma.numerosalamcenados();
        }
    }
}
