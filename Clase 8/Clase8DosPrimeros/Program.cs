using System;

namespace Clase8DosPrimeros
{
    //clase object,  metodo tostring()
    public class ClaseBasica
    {
        public string hola = "hola";
        public string saludo = "¿cómo estas?";
    }
    class Program
    {
        static void Main(string[] args)
        {
            object Objeto;
            Objeto = new ClaseBasica();
            ClaseBasica c;
            c = (ClaseBasica)Objeto;
            Console.WriteLine(c.hola);

            ClaseBasica u = new ClaseBasica();
            Console.WriteLine(u.saludo);

            Console.ReadLine();

            //metodo dateTime, clase Date
            DateTime today = DateTime.Today;
            Console.WriteLine("hoy es " + today.ToString("MMMM, dd, yyyy") + ".");
            Console.Write("Dentro de 5 dias sera: ");
            Console.WriteLine(today.AddDays(5));
        }
    }
}
