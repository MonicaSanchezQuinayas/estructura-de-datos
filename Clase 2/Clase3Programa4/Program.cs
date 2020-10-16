using System;

namespace Clase3Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            double salario = 0, porcentaje = 0, salariototal = 0;
            int cantidad = 0;

            Console.WriteLine("digita la cantidad de empleados");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("{0}º empleados", i + 1);
                Console.Write("");
                Console.Write("por favor digita el valor de tu salario:  ");
                entrada = Console.ReadLine();
                salario = Convert.ToInt32(entrada);
                Console.Write("");


                if (salario > 1500 && salario <= 3000)//Para un salario base mayor a 1500$ a 3000$ el porcentaje de retención es del 5%.
                {
                    porcentaje = salario * 0.5;
                    salariototal = salario - porcentaje;
                    Console.WriteLine(" el valor de tu salario neto: {0}  ", salariototal);
                }
                if (salario <= 1500)
                {
                    Console.WriteLine(" el valor de tu salario neto: {0}  ", salario);
                }

                if (salario > 3000) //Para un salario base mayor de 3000$ el porcentaje de retención es del 8%.
                {
                    porcentaje = salario * 0.8;
                    salariototal = salario - porcentaje;
                    Console.WriteLine(" el valor de tu salario neto: {0}  ", salariototal);

                }


            }
        }
    }
}
