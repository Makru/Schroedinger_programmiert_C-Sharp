using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Funktionen {
    class WoWItem {

    }
    class Position {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }

    class WoWCharacter {
        public int Health { get; private set; }
        public int Level { get; private set; }
        public Position Position { get; private set; }
        public float Strength { get; set; }
        public float Agility { get; set; }
        public float Speed { get; set; }
        public void Attack(WoWCharacter character) {
            // Use Strength + Agility + Health to calculate new halth.
        }
        public void Move(Position newPosition) {
            // Move in a 3d world
        }
        public void Die() {
        }
    }
}
