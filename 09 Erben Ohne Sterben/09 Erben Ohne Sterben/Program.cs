using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Erben_Ohne_Sterben {
    class Program {
        static void Main(string[] args) {
            SlimeGhost victim = new SlimeGhost("Smirgol");
            victim.Size = 5;
            CannibalGhost hungryGhost = new CannibalGhost("Hungry Boy");
            hungryGhost.Size = 1;
            hungryGhost.Eat(ref victim);
            Console.WriteLine("Die Größe von {0}: {1}", hungryGhost.Name, hungryGhost.Size);


            Ghost ghost = new SlimeGhost("Smirgol");
            Ghost ghost2 = new CannibalGhost("Eeat");
            Ghost[] ghosts = new Ghost[] { ghost, ghost2 };
            foreach (Ghost g in ghosts)
                g.Haunt();
        }
    }
}


