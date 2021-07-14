using System;

namespace Week1Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //routine
            Menu();

            int a = 1;
            int b = 2;
            int somma = 0;
            somma = Sum(a, b);


        }

        private static int Sum(int x, int y)
        {
            int z = x + y;
            return z;
        }

        private static void Menu()
        {
            Console.WriteLine("***MENU***");
            Console.WriteLine("1. Opzione1");
            Console.WriteLine("2. Opzione2");
            Console.WriteLine("3. Opzione3");
        }
    
    }
}
