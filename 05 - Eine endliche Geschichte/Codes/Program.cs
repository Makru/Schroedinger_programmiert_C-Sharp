using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class Program
    {
        enum Weekday
        {
            Monday = 1, Tuesday = 2, Wednesday = 4, Thursday = 8, Friday = 16, Saturday = 32, Sunday = 64
        }
        enum WoWVolk
        {
            Menschen, Zwerge, Gnome, Nachtelfen, Draenei, Worgen, Orcs, Untote, Tauren, Trolle, Blutelfen, Goblin, Pandaren
        }
        enum WoWKlasse
        {
            Druide, Hexenmeister, Jaeger, Krieger, Magier, Paladin, Priester, Schamane, Schurke, Todesritter, Moench
        }

        static void Main(string[] args)
        {
            Weekday myDay = Weekday.Friday;
            int weekday = (int)myDay;
            //Weekday anotherDay = (Weekday)7000;	// Auch das würde funktionieren.
            Console.WriteLine(weekday);
            Console.WriteLine(myDay.ToString());

            myDay.ToString(); // Umwandeln in den Text
            Weekday theDay = (Weekday)Enum.Parse(typeof(Weekday), "Monday");
            Console.WriteLine(theDay);

            WoWVolk meinVolk = WoWVolk.Orcs;
            if (meinVolk == WoWVolk.Orcs)
                Console.WriteLine("Dieses Volk spielt Schrödinger");
            else
                Console.WriteLine(meinVolk);
            Console.ReadKey();
        }
    }
}
