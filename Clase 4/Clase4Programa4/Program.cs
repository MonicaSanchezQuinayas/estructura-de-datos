using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Clase4Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
			int i;


			Console.WriteLine("dinos el tamaño del vector: ");
			int tamaño = int.Parse(Console.ReadLine());

			int[] vector_1 = new int[tamaño];
			string[] vector_2 = new string[tamaño];

			for (i = 1; i <= tamaño; i++)
			{
				Console.WriteLine("Ingresa nombre " + i + ": ");
				vector_2[i - 1] = Console.ReadLine();
				vector_1[i - 1] = vector_2[i - 1].Length;
			}

			for (i = 1; i <= tamaño; i++)
			{
				Console.WriteLine("La longitud de " + vector_2[i - 1] + " es de " + vector_1[i - 1] + " letras");
			}
		}
    }
}
