using System;
using System.Buffers;

namespace Clase4Programa11
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;
            double aprobados;
            double desaprobados;
            int i;
            double PromAprobados;
            double PromDesaprobados;
            double SumAprobados;
            double SumDesaprobados;
            int tamaño;


            Console.WriteLine("Digita la cantidad de notas: ");
            tamaño = int.Parse(Console.ReadLine());
            int[] Notas = new int[tamaño];

            for (int f = 0; f < Notas.Length; f++)
            {
                Console.Write("Ingrese el valor de la nota  [" + (f + 1) + "]: ");
                linea = Console.ReadLine();
                Notas[f] = int.Parse(linea);
            }

            aprobados = 0;
            desaprobados = 0;
            SumAprobados = 0;
            SumDesaprobados = 0;


            for (i = 0; i <= tamaño - 1; i++)
            {
                if (Notas[i] >= 10)
                {
                    aprobados = aprobados + 1;
                    SumAprobados = SumAprobados + Notas[i];
                }
                else
                {
                    desaprobados = desaprobados + 1;
                    SumDesaprobados = SumDesaprobados + Notas[i];
                }
            }

            PromAprobados = SumAprobados / aprobados;
            PromDesaprobados = SumDesaprobados / desaprobados;

            Console.WriteLine("Hay " + aprobados + " aprobados");
            Console.WriteLine("Hay " + desaprobados + " desaprobados");


            Console.WriteLine("El promedio de los aprobados es " + PromAprobados);
            Console.WriteLine("El promedio de los desaprobados es " + PromDesaprobados);
            Console.ReadLine();
        }
    }
}
