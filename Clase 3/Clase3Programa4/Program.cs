using System;

namespace Clase3Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            int estudiantes = 0, notas = 0, calificaciones = 0;
            int sumar = 0, promedio = 0;
            Console.WriteLine("digite la cantidad de estudiantes");
            estudiantes = int.Parse(Console.ReadLine());
            Console.WriteLine("digite la cantidad de notas: ");
            notas = int.Parse(Console.ReadLine());
            Console.Write("");

            for (int i = 1; i <= estudiantes; i++)
            {
                Console.WriteLine("{0}º estudiante", i);
                Console.Write("");

                for (int a = 1; a <= notas; a++)
                {
                    sumar = sumar + calificaciones;
                    Console.WriteLine("nota {0}º ", a);
                    calificaciones = int.Parse(Console.ReadLine());
                    Console.Write("");
                    sumar = sumar + calificaciones;
                    promedio = (sumar / notas);
                }
            }

            Console.WriteLine("la nota media es: {0} ", promedio);
        }
    }
}
