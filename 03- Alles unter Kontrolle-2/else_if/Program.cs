using System;

namespace else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Monat eingeben:");
            int month = int.Parse(Console.ReadLine());
            if (month == 1)
                Console.WriteLine("Der erste Monat dieses Jahres.");
            else if (month == 2)
                Console.WriteLine("Valentinstag nicht vergessen!");
            else if (month == 3 || month == 4)
                Console.WriteLine("Es ist März oder April!");
            //....
            else if (month == 12)
                Console.WriteLine("Es ist Dezember - Weihnachten, yippie.");
            else
                Console.WriteLine("Hey, so viele Monate hat das Jahr doch gar nicht.");
        }
    }
}
