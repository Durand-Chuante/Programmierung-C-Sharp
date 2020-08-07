using System;

namespace TryCatchUndFinaly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eine Zahl eintragen!");
            string zahl = Console.ReadLine();

            try
            {
                int input = int.Parse(zahl);
                int result = input / 0;
                System.Console.WriteLine("Die Anwort ist {0}", result);
            }
            catch(DivideByZeroException)
            {
                System.Console.WriteLine("Durch 0 teilen ist nicht erlaubt!");
            }
            catch(FormatException)
            {
                System.Console.WriteLine("Format inkorrekt! Fehler aufgetrten.");

            }
            catch(ArgumentException)
            {
                System.Console.WriteLine("Der wert war leer.");
            }
            catch(OverflowException)
            {
                System.Console.WriteLine("Die Zahl war sehr gross");
            }
            finally
            {
                System.Console.WriteLine("ich werde sowiso ausgefuehrt.");
            }

            
        }
    }
}
