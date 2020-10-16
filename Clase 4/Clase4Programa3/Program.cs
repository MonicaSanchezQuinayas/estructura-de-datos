using System;

namespace Clase4Programa3
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 0, suma = 0;
            int[] numeros = new int[10];

            numeros[0] = 2;
            numeros[1] = 5;
            numeros[2] = 8;
            numeros[3] = 10;
            numeros[4] = 13;
            numeros[5] = 15;
            numeros[6] = 18;
            numeros[7] = 20;
            numeros[8] = 23;
            numeros[9] = 25;

            for (contador = 0; contador < numeros.Length; contador++)
            {
                System.Console.WriteLine("el número " + (contador + 1) + " es igual a " + numeros[contador]);
            }

            //mostrar por pantalla la media de valores del array
            for (contador = 0; contador < numeros.Length; contador++)
            {
                suma = suma + numeros[contador];
            }

            System.Console.WriteLine("la media de valores de la matriz es:" + (suma / 10));
            Console.ReadKey();
        }
    }
}
