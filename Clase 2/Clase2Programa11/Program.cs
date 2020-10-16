using System;

namespace Clase2Programa11
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnos = 0, peso = 0, Menos40kg = 0, Mas40kg = 0, Mas50kg = 0, Mas60kg = 0;
            Console.WriteLine("Ingresa el número de alumnos");
            Console.WriteLine("");

            alumnos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < alumnos; i++)
            {
                Console.WriteLine("Tu peso es 1=Menos de 40kg , 2=Entre 40 y 50kg, 3=Mas40kg de 50 y menos de 60kg, 4=Mas40kg o igual a 60kg;");
                peso = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                switch (peso)
                {
                    case 1: Console.WriteLine("Alumnos que pesan menos de 40kg"); Menos40kg++; break;
                    case 2: Console.WriteLine("Alumnos que pesan entre 40 y 50kg"); Mas40kg++; break;
                    case 3: Console.WriteLine("Alumnos que pesan mas de 50 y menos de 60kg"); Mas50kg++; break;
                    case 4: Console.WriteLine("Alumnos que pesan mas o igual a 60kg"); Mas60kg++; break;
                }
            }
            Console.WriteLine("Alumnos que pesan menos de 40kg" + Menos40kg);
            Console.WriteLine("Alumnos que pesan entre 40 y 50kg" + Mas40kg);
            Console.WriteLine("Alumnos que pesan mas de 50 y menos de 60kg" + Mas50kg);
            Console.WriteLine("Alumnos que pesan mas o igual a 60kg" + Mas60kg);
        }
    }
}
