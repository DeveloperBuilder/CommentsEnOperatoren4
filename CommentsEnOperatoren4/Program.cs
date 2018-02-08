using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsEnOperatoren4
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Maak een console - applicatie, waarin u de leeftijd van Piet(55) en Henk(22) als variabelen opslaat.
            /// Laat middels de tenary operator het systeem bepalen welke van de twee het oudste is.
            /// Print daarnaast de totale leeftijd.
            int Piet = 55;
            int Henk = 22;

            int TotaleLeeftijd = Piet + Henk;
            Console.WriteLine(Piet > Henk ? "Piet" : "Henk");
            Console.WriteLine(TotaleLeeftijd);
            Console.ReadLine();
        }
    }
}
