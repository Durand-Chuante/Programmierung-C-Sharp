using System;

namespace verschachtelIf
{
    
    class Program
    {
        static string benutzername;
        static string Passwort;        
        static void Main(string[] args)
        {
            register();
            login();

            Console.ReadKey();
        }
        public static void register()
        {
            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine("Reistrieren Siesich\n");
            System.Console.WriteLine("Benutzername eingeben.");
            benutzername = Console.ReadLine();
            System.Console.WriteLine("Passwort eingeben");
            Passwort= Console.ReadLine();
            System.Console.WriteLine("Logen Sie sich ein: Benutzername eingeben!");
            System.Console.WriteLine("------------------------------------------------");
        }
        public static void login()
        {
            System.Console.WriteLine("Benutzername eingeben");
            if(benutzername == Console.ReadLine())
            {
                System.Console.WriteLine("Passwort eingeben");
                if(Passwort == Console.ReadLine())
                {
                    System.Console.WriteLine("einlogen war erfofgreich.");
                }
                else
                {
                    System.Console.WriteLine("einlogen schifgelaufen");
                }
            }
            else
            {
                System.Console.WriteLine("Benutzername exixtiert nicht.");
            }
        }
    }
}
