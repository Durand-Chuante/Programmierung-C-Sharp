using System;

namespace IfEl
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Wetter eingeben.");
            string eingabe = Console.ReadLine();
            int temp; // = int.Parse(eingabe);
            int numb;
            int pruef;

            bool isZahl = int.TryParse(eingabe, out numb);

            if(isZahl)
            {
                temp = numb;
            }
            else
            {
                temp = 0;
                pruef = temp;
                System.Console.WriteLine("Sie haben keine Zahl eingegeben.");
            }
            if(temp <= 10 && pruef != temp)
            {
                System.Console.WriteLine("Jetzt ist Winter!");
            }
            else if(temp <= 20 && temp > 10){
                Console.WriteLine("Jetzt ist Frueling.");
            }
            else if(temp > 20)
            {
                System.Console.WriteLine("Jetzt ist Sommer");
            }
            else
            {
                System.Console.WriteLine("falsche eingabe.");
            }
        
        }
    }
}
