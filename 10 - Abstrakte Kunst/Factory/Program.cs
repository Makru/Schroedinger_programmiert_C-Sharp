using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    class Program {
        static void Main(string[] args) {
            Shape myShape = ShapeFactory.GetShape();
            myShape.Draw();

            Shape[] shapes = new Shape[2];
            shapes[0] = new Rectangle();
            shapes[1] = new Circle();
            shapes[2] = new Triangle();

            foreach (Shape s in shapes)
                s.Draw();
        }
    }
}
