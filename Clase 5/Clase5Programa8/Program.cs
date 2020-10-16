using System;

namespace Clase5Programa8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[M1]");
            Console.Write("Filas: ");
            int F1 = int.Parse(Console.ReadLine());
            Console.Write("Columnas: ");
            int C1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" \n [M2]");
            Console.Write("Filas: ");
            int F2 = int.Parse(Console.ReadLine());
            Console.Write("Columnas: ");
            int c2 = int.Parse(Console.ReadLine());
            int[,] M1 = new int[F1 + 1, C1 + 1];
            int[,] M2 = new int[F2 + 1, c2 + 1];
            int[,] MR = new int[F1 + 1, c2 + 1];
            if (C1 == F2)
            {
                Console.WriteLine(" \n [M1]: ");
                for (int i = 1; i <= F1; i++)
                {
                    for (int j = 1; j <= C1; j++)
                    {
                        Console.WriteLine("Digita la posicion " + i + "," + j);
                        M1[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("[M2]: ");
                for (int i = 1; i <= F2; i++)
                {
                    for (int j = 1; j <= c2; j++)
                    {
                        Console.WriteLine("Digita la posicion " + i + "," + j);
                        M2[i, j] = int.Parse(Console.ReadLine());
                    }
                };
                for (int i = 1; i <= F1; i++)
                {
                    for (int j = 1; j <= c2; j++)
                    {
                        MR[i, j] = 0;
                        for (int z = 1; z <= C1; z++)
                        {
                            MR[i, j] = M1[i, j] * M2[i, j];
                        }
                    }
                }
                Console.WriteLine("La multiplicacion de las dos matrices es: ");
                for (int i = 1; i <= F1; i++)
                {
                    for (int j = 1; j <= c2; j++)
                    {
                        Console.Write("{0} ", MR[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Las matrices no se puedes multiplicar" + " Columnas: {0}! = Filas: {1}", C1, F2);
            }
            Console.Read();
        }
    }
}
