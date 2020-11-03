using System;

namespace Clase9Programa1
{
    class Program
    {
        int a;
        int b;

        public Program(int x, int y)
        {
            a = x;
            b = y;
        }
        public int Suma()
        {
            return a + b;
        }

        public int resta()
        {
            return a - b;
        }
        public int multiplicacion()
        {
            return a * b;
        }

        public int division()
        {
            return b / a;
        }
        class Principal
        {
            static void Main(string[] args)
            {

                Program obj = new Program(8, 20);
                Console.WriteLine("La suma es: " + obj.Suma());
                Console.WriteLine("La resta es: " + obj.resta());
                Console.WriteLine("La multiplicación es: " + obj.multiplicacion());
                Console.WriteLine("La división es: " + obj.division());
                Console.ReadKey();
            }
        }
    }
}



