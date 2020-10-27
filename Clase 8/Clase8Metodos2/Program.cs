using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Clase8Metodos
{
    class Program
    {
        private static bool strReplace;

        static void Main(string[] args)
        {
            //PadRight//
            string str = "Hello";
            string strPadRight = str.PadRight(10);
            Console.WriteLine(strPadRight);
            Console.ReadLine();

            //Remove//
            List<int> myPartyAges = new List<int> { 12, 23, 45, 65 };
            myPartyAges.Remove(12);
            foreach (int i in myPartyAges)
                Console.WriteLine(i);

            //Replace//
            string sentece = "Hola, mi nombre es Pepe.";
            string after = sentece.Replace('a', '0');
            Console.ReadLine();

            //Splir//
            string cadena = "53 asd 3 Hola 564";
            string[] arreglo = cadena.Split();
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            Console.ReadKey();

            //ToLower ToUppert//
            string a = "Let us cose";
            Console.WriteLine(a);
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.ToLower());
            Console.ReadLine();

            //TrimStart//
            String A = "Code Screens";
            String b = "|";
            Console.WriteLine(A + b);
            Console.WriteLine(A.TrimStart() + b);
            Console.ReadLine();

            //TrimEnd//
            String c = "Code Screens";
            String d = "|";
            Console.WriteLine(c + d);
            Console.WriteLine(c.TrimEnd() + d);
            Console.ReadLine();

            //Trim//
            string e = "Code Screens";
            string f = "|";
            Console.WriteLine(e + f);
            Console.WriteLine(e.Trim() + f);
            Console.ReadLine();

            //Append//
            string path = "document.txt";
            string text = File.ReadAllText(path);

            Console.WriteLine("Contenido actual");
            Console.WriteLine(text);
            Console.WriteLine("\n");

            File.AppendAllText(path, "Tercer Documento");
            text = File.ReadAllText(path);
            Console.WriteLine("Contenido Modificado: ");
            Console.WriteLine(text);
            Console.ReadKey(true);

            //WriteLine//
            Console.WriteLine("Hola a todos");

            //ToString//
            bool SioNo = false;
            Console.WriteLine(SioNo.ToString());
        }
    }
}
