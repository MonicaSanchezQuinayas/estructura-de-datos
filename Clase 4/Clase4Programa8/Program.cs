using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clase4Programa8
{
    class Program
    {
        private int[] algebra;

        private int comunes;


        public void Cargar()
        {
            Console.Write("Ingrese la cantidad de alumnos en la clase algebra ");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);


            algebra = new int[n];


            for (int f = 0; f < algebra.Length; f++)
            {
                Console.Write("Ingrese  el ID del estudiante [" + (f + 1) + "]: ");
                linea = Console.ReadLine();
                algebra[f] = int.Parse(linea);
            }
        }


        private int[] analisis;

        public void segundovector()
        {
            Console.Write("Ingrese la cantidad de alumnos de la clase analisis ");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);

            analisis = new int[n];

            for (int f = 0; f < analisis.Length; f++)
            {
                Console.Write("Ingrese  el ID del estudiante [" + (f + 1) + "]: ");
                linea = Console.ReadLine();
                analisis[f] = int.Parse(linea);
            }
        }
        public void repetidosvector2()
        {
            int cant = 0;
            comunes = analisis[0];

            for (int f = 0; f < analisis.Length; f++)
            {
                if (analisis[f] == comunes)
                {
                    cant++;
                }
            }
            if (cant > 1)
            {
                Console.WriteLine("Se repite" + cant + "alumnos en analisis");
            }
            else
            {
                Console.WriteLine("No se repite ningún alumnos ");
            }
            Console.ReadLine();
        }

        public void repetidosvector1()
        {
            Console.ReadLine();

            int cant = 0;
            comunes = algebra[0];

            for (int f = 0; f < algebra.Length; f++)
            {
                if (algebra[f] == comunes)
                {
                    cant++;
                }
            }
            if (cant > 1)
            {
                Console.WriteLine("Se repite " + cant + " alumno en algebra");
            }
            else
            {
                Console.WriteLine("No se repite ningún alumno.");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.Cargar();
            pv.segundovector();
            pv.repetidosvector2();
            pv.repetidosvector1();
        }
    }
    }
}
