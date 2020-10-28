using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    class Triangle : Shape {
        public override void Draw() {
            Console.WriteLine("Zeichne Dreieck");
        }
    }
}
