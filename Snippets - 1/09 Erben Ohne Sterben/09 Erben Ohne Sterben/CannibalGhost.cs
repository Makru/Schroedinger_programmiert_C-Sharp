using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Erben_Ohne_Sterben {
    class CannibalGhost : Ghost {
        public CannibalGhost(string name) : base(name) { }
        public void Eat(ref Ghost g) {
            this.Size += g.Size;
            g = null;
        }
        public void Eat(ref SlimeGhost g) {
            this.Size += g.Size;
            g = null;
        }
        public void Eat(ref CannibalGhost g) {
            this.Size += g.Size;
            g = null;
        }
    }
}
