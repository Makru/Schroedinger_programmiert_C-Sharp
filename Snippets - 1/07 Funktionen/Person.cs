using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Funktionen {
class Person {
    public Person(string name): this(name, 0) {
    }
    public Person() {
    }
    public Person(string name, float weight) {
        this.Name = name;
        this.Weight = weight;
    }
    public ~Person() {
        // Der hat hier nichts zu tun.
    }

    public string Name { get; set; }
    public float Weight { get; set; }

        public float WalkedKm { get; private set; }
        public int Footsteps { get; private set; }

        public void Walk(int footsteps) {
            if (footsteps > -1) {
                this.Footsteps += footsteps;
                // 1 Schritt sind ca. 75cm
                WalkedKm += footsteps * 0.75F / 1000.0F;
            }
        }

        public static float AverageWalkedKm(Person[] persons) {
            int amount = persons.Length;
            float walkSum = 0;
            foreach (Person p in persons)
                walkSum += p.WalkedKm;
            return walkSum / (float)amount;
        }
    }
}
