using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Klassengesellschaft {
    class Person {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        byte size;
        public byte Size {
            get {
                return this.size;
            }
            set {
                if (this.size > 0)
                    this.size = value;
            }
        }
        public string Fullname {
            get {
                return String.Format("{0} {1}", this.Firstname, this.Lastname);
            }
        }

        public string Fullname6 => $"{this.Firstname} {this.Lastname}";
    }
}
