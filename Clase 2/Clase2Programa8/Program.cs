using System;

namespace Clase2Programa8
{
    class Program
    {
        static void Main(string[] args)
        {
            int D, M, A;
            Console.WriteLine("Digite el Día: ");
            D = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el Mes: ");
            M = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el Año: ");
            A = int.Parse(Console.ReadLine());

            if (D >= 1 && D <= 30)
            {
                D = D + 1;
                Console.WriteLine("La fecha es: {0}/{1}/{2}", D, M, A);
            }
            if (D > 31)
            {
                Console.WriteLine("Esa fecha no existe");
            }
            if (D == 31 && M <= 11)
            {
                D = D - 30;
                M = M + 1;

                Console.WriteLine("La fecha es: {0}/{1}/{2}", D, M, A);
            }
            if (M > 12)
            {
                Console.WriteLine("Esa fecha no existe {0}", M);
            }
            if (M == 12 && D == 31)
            {
                D = D - 30;
                M = M - 11;
                A = A + 1;
                Console.WriteLine("La fecha es: {0}/{1}/{2}", D, M, A);
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
