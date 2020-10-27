using System;
using System.Globalization;

namespace programas_pract_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //metodo concat
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo concat:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            String s1 = "hola, profe ";
            String s2 = "¿cómo esta";
            String s3 = " usted?";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine("");
            Console.WriteLine("concatenamos todo");
            Console.WriteLine("");
            var s = String.Concat(s1, s2, s3);
            Console.WriteLine(s);
            Console.WriteLine("______________________________________");
            Console.Read();

            string nombre1 = "Mónica Sanchez";
            string nombre2 = "Sindy Melo";
            string nombre3 = "Mónica Sanchez";

            // método Eguals.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo equals:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            if (String.Equals(nombre1, nombre2))
                Console.WriteLine($"{nombre1} y {nombre2} son iguales.");
            else
                Console.WriteLine($"{nombre1} y {nombre2} son diferentes.");

            if (String.Equals(nombre1, nombre3))
                Console.WriteLine($"{nombre1} y {nombre3} son iguales.");
            else
                Console.WriteLine($"{nombre1} y {nombre3} son diferentes .");

            Console.WriteLine("______________________________________");
            Console.Read();

            // método compare.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo compare:   ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(nombre1 + " es diferente a " + nombre2 + " = " + nombre1.CompareTo(nombre2));
            Console.WriteLine(nombre1 + " es igual a " + nombre3 + " = " + nombre1.CompareTo(nombre3));
            Console.WriteLine("______________________________________");
            Console.Read();

            // método contains.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo contains:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            string c = "Mónica Sanchez es compañera de Sindy Melo ";
            if (c.Contains(nombre1)) ;
            Console.WriteLine(" {0} ", nombre1 + " se encuentra en la frase " + "'" + c + "'");
            Console.WriteLine("______________________________________");
            Console.Read();

            // método substring.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo substring:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(c.Substring(0, 36));
            Console.WriteLine("______________________________________");
            Console.Read();

            // método EndsWith.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo endwith:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(nombre2 + " empieza con la letra S " + nombre2.StartsWith("S"));
            Console.WriteLine(nombre2 + " finaliza con la letra o " + nombre2.EndsWith("o"));
            Console.WriteLine(nombre1 + " finaliza con la letra L " + nombre2.EndsWith("L"));

            Console.WriteLine("______________________________________");
            Console.Read();

            //metodo insert.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo insert:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            String original = "buenas tardes";
            Console.WriteLine("{0}", original);
            Console.WriteLine("");

            String modified = original.Insert(7, "queridos :) ");
            Console.WriteLine("insertamos la palabra 'queridos :)' ");
            Console.WriteLine("");
            Console.WriteLine("{0}", modified);
            Console.WriteLine("______________________________________");
            Console.Read();

            //método lastindexof.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo lastindexof:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            string oracion = "univeridad unipanamericana";
            Console.WriteLine("{0}", oracion);
            int indice = oracion.LastIndexOf("unipanamericana");
            Console.WriteLine("unipanamericana se encuentra a " + indice + " letras");
            Console.WriteLine("______________________________________");
            Console.Read();

            //método padleft.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo padleft:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            char pad = 'b';
            Console.WriteLine(original.PadLeft(15, pad));
            Console.WriteLine(original.PadLeft(2, pad));

            Console.WriteLine("______________________________________");
            Console.Read();

            //método copyto.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo copyto:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Array myArray = Array.CreateInstance(typeof(String), 3);
            myArray.SetValue("ingenieria", 0);
            myArray.SetValue("software", 1);
            Console.WriteLine("");
            PrintIndexAndValues(myArray);

            int[] myArrLen = { 4 };
            int[] myArrLow = { 2 };

            Array myArrayTwo = Array.CreateInstance(typeof(String), myArrLen, myArrLow);
            myArrayTwo.SetValue("hola", 2);
            myArrayTwo.SetValue("somos", 3);
            myArrayTwo.SetValue("estudiantes", 4);

            Console.WriteLine("");
            PrintIndexAndValues(myArrayTwo);
            myArray.CopyTo(myArrayTwo, 3);
            Console.WriteLine("");
            PrintIndexAndValues(myArrayTwo);
        }

        public static void PrintIndexAndValues(Array myArray)
        {
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, myArray.GetValue(i));
        }
    }

}