using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9programa3
{
    class Program
    {
        private string nombre;
        private int antiguedad;

        public Program()
        {
            Console.Write("Digita el nombre del socio:");
            nombre = Console.ReadLine(); ;
            Console.Write("Digita la antiguedad en años:");
            string linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene " + antiguedad + " años en la empresa");
        }

        public int RetornarAntiguedad()
        {
            return antiguedad;
        }
    }


    class Program2
    {
        private Program socio1, socio2, socio3;

        public Program2()
        {
            socio1 = new Program();
            socio2 = new Program();
            socio3 = new Program();
        }

        public void mayorantiguedad()
        {
            Console.Write("Socio con mayor antiguedad:");
            if (socio1.RetornarAntiguedad() > socio2.RetornarAntiguedad() &&
                socio1.RetornarAntiguedad() > socio3.RetornarAntiguedad())
            {
                socio1.Imprimir();
            }
            else
            {
                if (socio2.RetornarAntiguedad() > socio3.RetornarAntiguedad())
                {
                    socio2.Imprimir();
                }
                else
                {
                    socio3.Imprimir();
                }
            }

        }

        static void Main(string[] args)
        {
            Program2 club1 = new Program2();
            club1.mayorantiguedad();
            Console.ReadKey();
        }
    }
}
