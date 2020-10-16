using System;

namespace Clase3Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, contadorpar = 0, contadorimpar = 0;
            int sumarpar = 0, sumarimpar = 0, aritmetica = 0;

            Console.WriteLine("hola, por favor digita 10 números a continuación");
            Console.WriteLine("");

            for (int a = 1; a <= 10; a++)
            {
                Console.Write("digita cualquier número: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    contadorpar = contadorpar + 1;
                    sumarpar = sumarpar + num;
                }
                else
                {
                    contadorimpar = contadorimpar + 1;
                    sumarimpar = sumarimpar + num;
                }
            }

            aritmetica = sumarimpar / contadorimpar;
            Console.WriteLine("");
            Console.WriteLine(" la cantidad de números pares digitas es: {0}, por ello la suma de los pares es: {1}", contadorpar, sumarpar);
            Console.WriteLine("");
            Console.WriteLine(" la media aritmetica de los números impares es: {0}", aritmetica);
        }
    }
}
