using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Erben_Ohne_Sterben {
    class Ghost {
        public Ghost(string name) {
            this.Name = name;
        }
        public int Size { get; set; }
        public string Name { get; set; }
        public virtual void Haunt() {
            Console.WriteLine("{0} sagt: 'Buh'", this.Name);
        }
    }
}
