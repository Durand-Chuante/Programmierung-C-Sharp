using System;

namespace Hallo_Welt
{
    class Program
    {
        // Commentare wie im C
        static void Main(string[] args)
        {
            //Setzt die Hintergrundfarbe der Konsole
            Console.BackgroundColor = ConsoleColor.Blue;
            // set die Schrihtfarbe der Konsole
            Console.ForegroundColor = ConsoleColor.Red;
            // Ausgabe von einer Zeile auf der Konsole
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Durand!");
            //Formatierung Eingabe
            Console.ReadKey();
            
        }

    }
}
