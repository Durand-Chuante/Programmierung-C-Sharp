using System;

namespace SwitchCase
{
    class Program
    {
        static int Highscore = 300;
        static string HighscorePlayer = "Durand";
        //int neuerhighscore;

        static void Main(string[] args)
        {
           game(200, "alex");
           game(320, "Ines");
           game(100, "Yohan");
        }
        public static void game(int score, string name)
        {
            if(score > Highscore)
            {
                Highscore = score;
                HighscorePlayer = name;
                System.Console.WriteLine("Neuer rekordhalter ist {0} mit {1} punkte", name, Highscore);
            }
            else
            {
                 System.Console.WriteLine("alte rekordhalter konnte nicht gebrochen werden" + 
                  "Er ist {0} mit {1} punkte", HighscorePlayer, Highscore);

            }

        }
    }
}
