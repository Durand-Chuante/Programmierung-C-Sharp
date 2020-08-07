using System;

namespace MethodeRueckgabeWert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string name1 = "Yohan";
            string name2 = "Ines";
            string name3 = "Durand";

            Greetfriend(name1);
            Greetfriend(name2);
            Greetfriend(name3);
            Console.ReadKey();

        }
        public static void Greetfriend(string name)
        {
            Console.WriteLine("Hallo meinen Freunden {0}!", name);
        }   
    } 
        
}
