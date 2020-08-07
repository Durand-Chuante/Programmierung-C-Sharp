using System;

namespace Typen
{
    class Program
    {
        static void Main(string[] args)
        {
            double wert1 = 12.43;
            double wert2;
            wert2 = 32.43;
            double sum = wert1 + wert2;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Die Summe ist: " + sum);
            //Console.ReadKey();
        }
    }
}
