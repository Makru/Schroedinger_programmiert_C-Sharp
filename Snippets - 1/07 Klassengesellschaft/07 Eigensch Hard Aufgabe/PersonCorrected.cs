using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Eigensch_Hard_Aufgabe {
class PersonCorrected {
    public Sex Sex { get; set; }
    public string Lastname { get; set; }
    public string Firstname { get; set; }

    int age;
    public int Age {
        get { return this.age; }
        set {
            if (this.age > 0)
                this.age = value;
        }
    }

    public string Fullname {
        get {
            return String.Format("{0} {1}", this.Firstname, this.Lastname);
        }
    }

    byte Size { get; private set; }
}
}
