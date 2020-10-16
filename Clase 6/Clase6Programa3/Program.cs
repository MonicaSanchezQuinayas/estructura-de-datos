using System;
using System.Collections;

namespace Clase6Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList miLista = new ArrayList();

            int x = 0;
            int numero = 0;
            string valor = "";
            int encontrar = 0;
            Console.WriteLine("Por favor, digita el valor del primer elemento  ");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

            // recibir la dirección del primer elemento 

            Console.WriteLine(" y digita la posición del primer elemento: ");
            valor = Console.ReadLine();
            x = Convert.ToInt32(valor);


            miLista.Add(2);
            miLista.Add(3);
            miLista.Add(4);
            miLista.Add(5);

            Console.WriteLine("Contenido actual:");
            foreach (int n in miLista)
                Console.WriteLine(n);

            //mostrar la dirección donde existe el numero 

            if (x < miLista.Count)
            {
                miLista.Insert(x, numero);
                Console.WriteLine("Contenido tras insertar:");

                for (int i = 0; i < miLista.Count; i++)
                    Console.WriteLine(miLista[i]);
            }

            if (x > miLista.Count)
            {
                Console.WriteLine(" ***** ubicación invalido ******* ");
            }


            //si existe el elemento

            Console.WriteLine("Dame el valor a encontrar");
            valor = Console.ReadLine();
            encontrar = Convert.ToInt32(valor);

            if (encontrar < miLista.Count)
            {
                Console.WriteLine("el valor digita esta en la posición {0}", miLista.IndexOf(encontrar + 1));
            }
            else
                Console.WriteLine("valor no encontrado");
        }
    }
}
