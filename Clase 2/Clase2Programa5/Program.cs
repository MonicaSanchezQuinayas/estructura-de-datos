using System;

namespace Clase2Programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            // un vendedor desea calcular su comisión total sobre la venta de varios articulos.
            //Al vendedor le corresponde el 5% de comisión por los articulos cuyo precio es menor de 10 pesos 
            // y el 7.5% de comisión por los articulos cuyo precio sea mayor o igual a 10bs.f//


            double costoventas, venta, ventas1, ventas2, comisiontotal1, comisiontotal2;

            Console.WriteLine("Hoy vamos a hallar la comisión total de ventas");
            Console.WriteLine("");
            Console.WriteLine("por favor digital el costo de venta: ");
            venta = double.Parse(Console.ReadLine());
            Console.WriteLine("por favor digital el costo de venta: ");
            ventas1 = double.Parse(Console.ReadLine());
            Console.WriteLine("por favor digital el costo de venta: ");
            ventas2 = double.Parse(Console.ReadLine());

            if (venta <= 10 && ventas1 <= 10 && ventas2 <= 10)
            {
                costoventas = venta + ventas1 + ventas2;
                comisiontotal1 = costoventas * 0.5;
                Console.WriteLine("comisión total por ventas: {0} pesos", comisiontotal1);
            }

            else if (venta >= 10000 && ventas1 >= 10000 && ventas2 >= 10000)
            {
                costoventas = venta + ventas1 + ventas2;
                comisiontotal2 = costoventas * 0.075;
                Console.WriteLine("comisión total por ventas: {0} pesos", comisiontotal2);
            }
        }
    }
}
