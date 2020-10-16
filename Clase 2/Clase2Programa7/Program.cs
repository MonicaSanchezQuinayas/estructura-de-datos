using System;

namespace Clase2Programa7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string entrada = "";

            Console.WriteLine(" hola, por favor digita tres numeros:");
            Console.WriteLine(" primer numero:");
            entrada = Console.ReadLine();
            num1 = Convert.ToInt32(entrada);

            Console.WriteLine(" segundo numero:");
            entrada = Console.ReadLine();
            num2 = Convert.ToInt32(entrada);

            Console.WriteLine(" tercer numero:");
            entrada = Console.ReadLine();
            num3 = Convert.ToInt32(entrada);

            if (num2 < num1 && num1 < num3 && num3 < num1 && num1 < num2)
            {
                Console.WriteLine("el numero del medio es: {0}", num1);
            }
            else
            {
                Console.WriteLine(" el número del medio es: {0}", num2);
            }
            if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine(" el número del medio es: {0}", num2);
            }
            if (num1 < num3 && num3 < num2 && num2 < num3 && num3 < num1)
            {
                Console.WriteLine(" el número del medio es: {0}", num3);
            }
            if (num1 == num2 && num2 == num3 && num3 == num1)
            {
                Console.WriteLine("se digito el mismo número");
            }
        }
    }
}
