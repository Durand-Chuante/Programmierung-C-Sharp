using System;

namespace parsing
{
    class Program
    {
        const string birthday = "14.12.1991";

        static void Main(string[] args)
        {
            string meinStrint = "12";
            string mein2string = "13";

            int num1;
            int num2;
            num1 = int.Parse(meinStrint);
            num2 = int.Parse(mein2string);

            int result = num1 + num2;
            System.Console.WriteLine("mein Geburtstag ist am {0}", birthday);

            Console.WriteLine(result);
        }
    }
}
