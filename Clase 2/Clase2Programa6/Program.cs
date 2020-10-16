using System;

namespace Clase2Programa6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinar el precio de un pasaje en ferrocarril,
            //conociendo la distanciaa recorrer y sabiendo que,
            //si el número de días de estancia es superior a siete y la distancia superior a 800 kilómetros,
            //el pasaje tiene una reducción del 30%. El precio por kilómetro es de 2.5$//. 
            static void Main(string[] args)
            {

                double distancia = 0, dias = 0;
                double operacion, pasaje, pasaje1;
                string entrada = "";


                Console.WriteLine("precio del pasaje");
                Console.WriteLine("");
                Console.WriteLine("por favor digite la distancia recorrida:  ");
                distancia = double.Parse(Console.ReadLine());


                Console.WriteLine("");
                Console.WriteLine("por favor digite los dias que te quedaras: ");
                dias = double.Parse(Console.ReadLine());


                operacion = distancia * 2.5;

                if (dias >= 7 && distancia >= 800)
                {
                    pasaje = operacion - (distancia * 2.5) * 0.3;
                    Console.WriteLine(" precio del pasaje: {0} pesos", pasaje);
                }

                else
                {
                    Console.WriteLine(" precio del pasaje: {0} pesos", operacion);
                }
            }
        }
    }
}
