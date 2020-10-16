using System;

namespace Clase1Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            float super = 0.0f;
            float alt = 0.0f;
            float resultado = 0.0f;
            string entrada;


            Console.WriteLine("Hola, hoy vamos a calcular la base de un triangulo teniendo superficie y altura");
            Console.WriteLine("");

            Console.WriteLine("digita la altura");
            entrada = Console.ReadLine();
            alt = Convert.ToInt32(entrada);

            Console.WriteLine("Digita la base");
            entrada = Console.ReadLine();
            super = Convert.ToInt32(entrada);

            resultado = (2 * super) / alt;
            Console.WriteLine("El valor del area es igual a = {0} la altura digitada es de {1} por lo tanto la base del triangulo es = {2}", super, alt, resultado);

        }
    }
}
