using System;

namespace Clase1Programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            float kg = 0.453592f;
            float lb = 2.20462f;
            float rlb = 0.0f;
            float rkg = 0.0f;
            float kgr = 0.0f;
            string entrada = "";

            Console.WriteLine("Hola, hoy vamos ha calcular el peso de una persona en lb y devolverlo a kg");
            Console.WriteLine("");

            Console.WriteLine("Digita el peso en kg");
            entrada = Console.ReadLine();
            kgr = Convert.ToInt32(entrada);

            rlb = (kgr * lb) / 1;
            Console.WriteLine("Tu peso en kilos es {0} por lo tanto tu peso en libras es {1}", kgr, rlb);

            rkg = (rlb * kg) / 1;
            Console.WriteLine("Tu peso en libras en {0} por lo tanto tu peso en kilos es {1}", rlb, rkg);
        }
    }
}
