using System;

namespace Benutzereingabe
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
           System.Console.WriteLine("erste Zahl eigeben: ");
            string input1 = Console.ReadLine(); 
            num1 = int.Parse(input1);
            System.Console.WriteLine("zweite Zahl eigeben: ");
            string input2 = Console.ReadLine();
            num2 = int.Parse(input2);
            System.Console.WriteLine("Die summe ist: {0}", add(num1, num2));
        }
        
        public static int add(int a, int b)
        {
            int summ = a +b;
            return summ;
        }
    }
}
