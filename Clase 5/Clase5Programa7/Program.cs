
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Programa7
{
    class Program
    {
        static void Main(string[] args)
        {
             //escribe un programa que sume los elementos de dos tablas o matrices

        private int[,] m1, m2, mr;
        public void vectores()
        {
            Console.WriteLine(" vector [M1]: ");

            m1 = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("       digita el valor [" + (i + 1) + "  " + (j + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    m1[i, j] = int.Parse(linea);
                }
            }

            Console.WriteLine("vector [M2]: ");

            m2 = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("       digita el valor [" + (i + 1) + "  " + (j + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    m2[i, j] = int.Parse(linea);
                }
            };

            Console.WriteLine(" ");
            Console.WriteLine(" vector  [M1]:  ");
            Console.WriteLine(" ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("  " + m1[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(" ");
            Console.WriteLine(" vector  [M2]:  ");
            Console.WriteLine(" ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("  " + m2[i, j] + "  ");
                }
                Console.WriteLine();
            }


            //suma el vector m1 con el m2 y almacenarlo  en mr

            int[,] MR = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MR[i, j] = 0;

                    for (int z = 0; z < 3; z++)
                    {
                        MR[i, j] = m1[i, j] + m2[i, j];
                    }
                }
            }

            Console.WriteLine("La suma de las dos matrices es: ");
            Console.WriteLine(" ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ", MR[i, j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }


        static void Main(string[] args)
        {
            Program ma = new Program();
            ma.vectores();
        }
    }
}
