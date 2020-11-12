using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    class Rectangle : Shape {
        public override void Draw() {
            // Zeichnen simulieren ;-)
            Console.WriteLine("Zeichne Rechteck");
        }
    }
}
