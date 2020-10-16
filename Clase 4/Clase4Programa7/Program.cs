using System;

namespace Clase4Programa7
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
                    Console.WriteLine("los repetidos son: " + cant++);
                }
            }
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
                    Console.WriteLine("los repetidos son: " + cant++);
                }
            }
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
