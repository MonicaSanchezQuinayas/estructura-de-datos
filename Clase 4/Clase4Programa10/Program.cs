using System;

namespace Clase4Programa10
{
    class Program
    {
        private int[] aleatorio;
        static void Main(string[] args)
        {

            var random = new Random();
            int i;
            int impar;
            int PCentral;
            Console.WriteLine("Escribe un numero impar");
            impar = int.Parse(Console.ReadLine());
            int[] NAaleatorios = new int[impar];
            Random aleatorio = new Random();

            for (i = 0; i <= impar - 1; i++)
            {
                NAaleatorios[i] = random.Next();
            }
            for (i = 0; i <= impar - 1; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("" + NAaleatorios[i]);
            }

            Console.WriteLine("");
            PCentral = Convert.ToInt32(impar / 2);
            Console.WriteLine("Posicion central: " + NAaleatorios[PCentral]);
            Console.ReadLine();
        }
    }
}
