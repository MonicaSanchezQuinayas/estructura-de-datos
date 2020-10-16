using System;

namespace Clase1Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            int b = 0;
            int alt = 0;
            int resultado = 0;

            Console.WriteLine("hola hoy vamos a hallar el valor de la superficie de un triangulo");
            Console.WriteLine("");


            Console.WriteLine("Digita la base");
            entrada = Console.ReadLine();
            b = Convert.ToInt32(entrada);

            Console.WriteLine("Digita la altura");
            entrada = Console.ReadLine();
            alt = Convert.ToInt32(entrada);


            resultado = (alt * b) / 2;
            Console.WriteLine("El valor de la base es = {0} y el valor de la altura es {1} por lo que el resultado es = {2}", b, alt, resultado);

        }
    }
}
