using System;

namespace ErweiteteIf
{
    class Program
    {
        //Bedingung ? erste Ausdruck : Zweite Ausdruck
        //Bedingung muss entweder wahr oder falsch sein (true / false)
        //Der konditionelle Operator ist rechtassociativ
        //Der ausdruck a ? b : c ? d : e
        //wird so evaluiert a ? b : (c ? d : e)
        //und nicht als (a ? b : c) ? d : e
        //Der konditionelle Operator kan nicht überschrieben werden
        static void Main(string[] args)
        {
            int temperature = -5;
            string stateOfMatter;

            if(temperature < 0)
            {
                stateOfMatter = "fest";
            }
            else
            {
                stateOfMatter = "fluessig";
            }
            System.Console.WriteLine("Aggregatzustand ist {0}", stateOfMatter);

        }
    }
}
