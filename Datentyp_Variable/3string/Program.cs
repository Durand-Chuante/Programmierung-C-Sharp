using System;

namespace _3string
{
    class Program
    {
        static void Main(string[] args)
        {
            string meinName = "Durand";
            string nachricht = "Mein Name ist " + meinName;
            int laenge = nachricht.Length;
            Console.WriteLine(nachricht + " ist {0} Zeichen lang.", laenge);

            // konkatenation
            Console.WriteLine("Hello " + nachricht);
            // Die Methode ToUpper schreibt in Gross Buschtabe
            string allesGros = nachricht.ToUpper();
            Console.WriteLine(allesGros);
            //Die Methode ToLawer schreibt alles in kleinBuchtabe
            string allesklein = nachricht.ToLower();
            System.Console.WriteLine(allesklein);
            
            Console.ReadKey();

        }
    }
}
