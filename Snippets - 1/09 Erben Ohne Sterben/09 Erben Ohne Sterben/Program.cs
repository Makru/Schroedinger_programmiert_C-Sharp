using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Erben_Ohne_Sterben {
    class Program {
        static void Main(string[] args) {
            SlimeGhost ghost3 = new SlimeGhost("Smirgol");
            ghost3.Size = 5;
            CannibalGhost ghost4 = new CannibalGhost("Eeat");
            ghost4.Size = 1;
            ghost4.Eat(ref ghost3);
            Console.WriteLine("Die Größe von {0}: {1}", ghost4.Name, ghost4.Size);


            Ghost ghost = new SlimeGhost("Smirgol");
            Ghost ghost2 = new CannibalGhost("Eeat");
            Ghost[] ghosts = new Ghost[] { ghost, ghost2 };
            foreach (Ghost g in ghosts)
                g.Haunt();
        }
    }
}


