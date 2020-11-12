using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Erben_Ohne_Sterben {
    class SlimeGhost : Ghost {
        public SlimeGhost(string name)
            : base(name) {
        }
        public override void Haunt() {
            this.Slime();
            base.Haunt();
        }

        public void Slime() {
            Console.WriteLine("{0} hinterlässt eine Schleimspur.", this.Name);
        }
    }
}
