using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Struct {
    partial struct Person {
        public static void Switch(Person p1, Person p2) {
            Person p3 = p1;
            p1 = p2;
            p2 = p3;
            p1.Name += " (getauscht)";
            p2.Name += " (getauscht)";
        }
    }
}
