using System;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            string myargument = "Ich bin ein super Text";
            writeSomething();
            writeSomething();
            writeSomething();
            writeSomethingSpecific(myargument);
        }
        //Methode
        public static void writeSomething()
        {
            System.Console.WriteLine("Ich bin eine Methode");
            //Console.ReadKey();
        }
        public static void writeSomethingSpecific(string myText)
        {
            System.Console.WriteLine(myText);
        }
    }
}
