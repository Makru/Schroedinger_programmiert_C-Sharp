using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Eigensch_Hard_Aufgabe {
    enum Sex {
        Male,
        Female
    }
    class Person {
    public Sex Sex { get; set; }

    string lastname;
    public string Lastname {
        get { return this.lastname; }
        set { lastname = value; }
    }
    
    public string Firstname;

    int age;
    public int Age {
        get { return age; }
        set {
            if (age > 0)
                this.age = value;
        }
    }

    public string Fullname {
        get {
            return String.Format("{0} {1}", this.Firstname, this.lastname);
        }
        set {
            string[] nameParts = value.Split(' ');
            this.Firstname = nameParts[0];
            lastname = nameParts[1];
        }
    }

    byte size;
    public byte Size {
        get { return this.size; }
        set { }
    }
}
}
