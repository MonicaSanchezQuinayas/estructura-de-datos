using System;

namespace Clase9Programa2
{
    class Program
    {
        private string nombre;
        private int sueldo;

        public Program()
        {
            Console.Write("Digita nombre:");
            nombre = Console.ReadLine();
            Console.Write("Digita sueldo:");
            string linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Sueldo:" + sueldo);
        }

        public void sueldomayor()
        {
            Console.WriteLine("");
            if (sueldo >= 3000)
            {
                Console.Write(nombre + " Debes impuestos");
            }
            else
            {
                Console.Write(nombre + " No debes impuestos.");
            }
        }

        static void Main(string[] args)
        {
            Program trabajador = new Program();
            trabajador.Imprimir();
            trabajador.sueldomayor();
            Console.ReadKey();
        }
    }
}

