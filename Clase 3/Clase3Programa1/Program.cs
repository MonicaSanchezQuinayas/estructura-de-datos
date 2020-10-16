using System;

namespace Clase3Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumapar = 0, sumaimpar = 0, num = 0;
            int i = 0;

            Console.WriteLine(" hola, hoy vamos a hallar la suma de los números pares e impares");
            Console.WriteLine("");
            Console.WriteLine(" digita un número dentro de 1 a 200: ");
            num = int.Parse(Console.ReadLine());

            for (i = 0; i <= num; i++)
            {

                if (i % 2 == 0)
                {
                    sumapar = sumapar + i;
                }
                else
                    sumaimpar = sumaimpar + i;

            }
            Console.WriteLine(" la suma de los números pares es: {0}", sumapar);
            Console.WriteLine(" la suma de los números impares es: {0}", sumaimpar);
        }
    }
}
