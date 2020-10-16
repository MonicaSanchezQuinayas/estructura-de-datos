using System;

namespace Clase4Programa9
{
    class Program
    {
        static void Main(string[] args)
        {
			double Elemento;
			bool ElementoNoRepetido;
			int i;
			int NumeroElementos;
			int Tamaño;
			Console.WriteLine("Digita el tamaño del vector");
			Tamaño = int.Parse(Console.ReadLine());
			double[] NumerosNoRepetidos = new double[Tamaño];
			NumeroElementos = 0;
			Elemento = 0;
			ElementoNoRepetido = true;
			while (NumeroElementos < Tamaño)
			{
				Console.WriteLine("Digita un número, no repetir");
				Elemento = Double.Parse(Console.ReadLine());
				for (i = 0; i <= NumeroElementos - 1; i++)
				{
					if (Elemento == NumerosNoRepetidos[i])
					{
						ElementoNoRepetido = false;
					}
				}
				if (ElementoNoRepetido)
				{
					NumerosNoRepetidos[NumeroElementos] = Elemento;
					NumeroElementos = NumeroElementos + 1;
				}
				else
				{
					Console.WriteLine("Este elemento existe en el arrays");
				}
				ElementoNoRepetido = true;
			}
			for (i = 0; i <= Tamaño - 1; i++)
			{
				Console.WriteLine(NumerosNoRepetidos[i]);
				Console.ReadLine();
			}
		}
    }
}
