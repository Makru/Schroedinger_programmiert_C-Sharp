using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lists {
    public class Person : ModelBase {
        string firstname;
        public string Firstname {
            get { return firstname; }
            set {
                if (firstname != value) {
                    firstname = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged("Fullname");
                }
            }
        }
        string lastname;
        public string Lastname {
            get { return lastname; }
            set {
                if (lastname != value) {
                    lastname = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged("Fullname");
                }
            }
        }
        public string Fullname {
            get {
                return String.Format("{0} {1}", this.Firstname, this.Lastname);
            }
        }
    }
}
