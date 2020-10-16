using System;

namespace Clase2Programa10
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario = 0;
            int sexo = 0, estado = 0;
            double mujeres = 0, hombres = 0, totalmujeres = 0, totalhombres = 0, promedio = 0, edad = 0, edadpromedio = 0;
            string entrada = "";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}º trabajador", i + 1);
                Console.Write("1 = Femenino / 2 = Masculino:  ");
                entrada = Console.ReadLine();
                sexo = Convert.ToInt32(entrada);

                Console.Write("tu estado civil: 1 =soltero(a) / 2=casado(a) / 3=viudo(a) ");
                entrada = Console.ReadLine();
                estado = Convert.ToInt32(entrada);

                Console.Write("¿cuantós años tienes?  ");
                entrada = Console.ReadLine();
                edad = Convert.ToInt32(entrada);

                Console.Write("¿cuantó es tu salario?  ");
                entrada = Console.ReadLine();
                salario = Convert.ToSingle(entrada);
                Console.WriteLine("");


                if (sexo == 1)//total de mujeres
                {
                    mujeres = mujeres + sexo;
                }
                if (sexo == 2)//total de hombres
                {
                    hombres = hombres + sexo;
                    edadpromedio = edadpromedio + edad;
                    promedio = edadpromedio / hombres;
                    Console.WriteLine("promedio de edad hombres: {0} ", promedio);
                }

                if (sexo == 1 || estado == 3 || salario >= 600) //Total de mujeres viudas que ganan másde 600 Bs
                {
                    totalmujeres = totalmujeres + sexo;
                    Console.WriteLine("Total de mujeres viudas que ganan más de 600 Bs: {0}", totalmujeres);
                }


                if (sexo == 2 || estado == 2 || salario >= 1000) //Total de hombres casados que ganan más de 1000 Bs.F.
                {
                    totalhombres = totalhombres + sexo;
                    Console.WriteLine("Total de hombres casados que ganan más de 1000 Bs: {0}", totalhombres);
                }

            }
            Console.WriteLine("cantidad de hombres: {0} ", hombres);
            Console.WriteLine("promedio de edad hombres: {0} ", promedio);
            Console.WriteLine("total de mujeres: {0} ", mujeres);
        }
    }
}
