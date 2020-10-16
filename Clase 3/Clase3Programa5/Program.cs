using System;

namespace Clase3Programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_mayor = 0, cantidad = 0, num = 0;

            Console.WriteLine("por favor digite el limite de la secuencia ( menor a -99)");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
                do
                {
                    Console.WriteLine("ingrese el valor del numero {0}º:  ", i + 1);
                    num = int.Parse(Console.ReadLine());

                }
                while (i < -99);

            if (num != 0)
            {
                if (num > numero_mayor)
                    numero_mayor = num;
            }

            Console.WriteLine("el numero mayor es {0}", numero_mayor);
        }
    }
}
