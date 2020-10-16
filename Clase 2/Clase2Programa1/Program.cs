using System;

namespace Clase2Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            string valor = "";

            Console.WriteLine("por favor digita un número:");
            valor = Console.ReadLine();
            num1 = Convert.ToInt32(valor);
            Console.WriteLine(" regalame otro número: ");
            valor = Console.ReadLine();
            num2 = Convert.ToInt32(valor);
            Console.WriteLine("regalame otro número:");
            valor = Console.ReadLine();
            num3 = Convert.ToInt32(valor);
            Console.WriteLine("  y el ultimo número: ");
            valor = Console.ReadLine();
            num4 = Convert.ToInt32(valor);

            if (num1 > num2 && num1 > num3 && num1 > num4)
            {
                Console.WriteLine("el número mayor es: {0}", num1);
                Console.WriteLine("");
            }
            if (num2 > num1 && num2 > num3 && num2 > num4)
            {
                Console.WriteLine("el número mayor es: {0}", num2);
                Console.WriteLine("");
            }
            if (num3 > num2 && num3 > num1 && num3 > num4)
            {
                Console.WriteLine("el número mayor es: {0}", num3);
                Console.WriteLine("");
            }
            if (num4 > num1 && num4 > num2 && num4 > num3)
            {
                Console.WriteLine("el número mayor es: {0}", num4);
                Console.WriteLine("");
            }
        }
    }
}
