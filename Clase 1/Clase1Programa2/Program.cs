using System;

namespace Clase1Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.1416f;
            float rad = 0.0f;
            float petr = 0.0f;
            float ar = 0.0f;
            string entrada;


            Console.WriteLine("Hola, hoy vamos a calcular el area de un circulo!");
            Console.WriteLine("");
            Console.WriteLine("Digita la medida del radio");
            entrada = Console.ReadLine();
            rad = Convert.ToSingle(entrada);

            petr = (2 * pi) * rad;
            Console.WriteLine("El perimero es  : {0}", petr);
            Console.WriteLine("");
            ar = (pi * rad * rad);
            Console.WriteLine("El area del circulo es : {0}", ar);
            Console.WriteLine("");
        }
    }
}
