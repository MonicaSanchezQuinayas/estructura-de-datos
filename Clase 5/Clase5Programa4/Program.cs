using System;

namespace Clase5Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
             private int[,] mat;
        public void Cargar()
        {
            mat = new int[3, 3];

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
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


            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(" " + mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void diagonalprincipal()
        {
            //almacena en la diagonal principal el menor de ese reglon

            Console.WriteLine(" ");
            Console.WriteLine("  la diagonal principal es:  ");
            Console.WriteLine(" ");

            int menor = mat[0, 0];

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (f == c && mat[f, c] < menor)

                    {
                        menor = mat[f, c];
                        Console.WriteLine(" " + menor);
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            Program ma = new Program();
            ma.Cargar();
            ma.Imprimirvector();
            ma.diagonalprincipal();

        }
    }
}
