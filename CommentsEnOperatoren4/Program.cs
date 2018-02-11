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
            
            int PietAge = 55;
            int HenkAge = 22;

            int TotaleLeeftijd = PietAge + HenkAge;
            Console.WriteLine(PietAge > HenkAge ? "Piet is the oldest" : "Henk is the oldest");
            Console.WriteLine("The total age of Piet and Henk are {0} ", TotaleLeeftijd);
            ConsoleApplication4.Program2.pietHenk();
            Console.ReadLine();
        }
    }
    namespace ConsoleApplication4
    {
        class Program2
        {
            public static void pietHenk()
            {
                int piet = 55;
                int henk = 22;

                string oudste = ((piet > henk) ? "piet" : "henk");
                int totaal = piet + henk;

                Console.WriteLine(" " + "\n" + oudste);
                Console.WriteLine(totaal);
                // Zorgt ervoor dat de console niet sluit. 
                // Wacht feitelijk op een invoer van de gebruiker
            }
        }
    }
}
