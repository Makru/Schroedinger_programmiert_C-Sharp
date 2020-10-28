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
                Console.WriteLine("Wie wäre es mit Horror?");
                bool horror = bool.Parse(Console.ReadLine());
                if (horror)
                    Console.WriteLine("Gute Wahl heute wirds gruselig.");
                else
                {
                    Console.WriteLine("Doch ein Actionfilm?");
                    bool action = bool.Parse(Console.ReadLine());
                    if (action)
                        Console.WriteLine("Ein guter Actionfilm ist immer toll.");
                    else
                    {
                        Console.WriteLine("Thriller?");
                        bool thriller = bool.Parse(Console.ReadLine());
                        if (thriller)
                            Console.WriteLine("Oh es wird spannend. Ein Thriller steht an.");
                        else
                        {
                            Console.WriteLine("Dann gibt es heute kein Fernsehen.");
                        }
                    }
                }
            }
        }
    }
}
