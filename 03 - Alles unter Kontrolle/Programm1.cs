using System;
namespace Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Freundin da? (true, false):");
            bool freundinDa = bool.Parse(Console.ReadLine());
            if (freundinDa == true)
            {
                Console.WriteLine("Kanal auf dem Titanic läuft:");
                int kanal = int.Parse(Console.ReadLine());
                Console.WriteLine("Tja, heute wird Titanic angesehen. Kanal: " + kanal);
            }
            else
            {
                Console.WriteLine("Horror (true) oder Action (false)?");
                bool horror = bool.Parse(Console.ReadLine());
                if (horror)
                    Console.WriteLine("Gute Wahl heute wirds gruselig.");
                else
                    Console.WriteLine("Ein guter Actionfilm ist immer toll.");
            }
            Console.ReadKey();
        }
    }
}