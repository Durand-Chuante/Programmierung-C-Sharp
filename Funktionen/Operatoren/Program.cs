using System;

namespace Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;
            num3 = -num2;
            Console.WriteLine("num3 ist {0}", num3);

            bool issony = true;
            System.Console.WriteLine("ist es sonnig {0}", issony);
            // Incrementoperatoren
            //num1++;
            System.Console.WriteLine("num1 ist {0}", ++num1);

            Console.ReadKey();
        }
    }
}
