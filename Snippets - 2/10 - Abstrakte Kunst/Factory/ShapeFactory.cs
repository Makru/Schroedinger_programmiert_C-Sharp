using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
class ShapeFactory {
    public static Shape GetShape() {
        return new Rectangle();
    }
}
}
