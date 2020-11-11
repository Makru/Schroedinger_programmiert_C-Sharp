using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IdCard {
    public class Person : ModelBase {
        string name;
        public string Name {
            get { return name; }
            set {
                if (name != value) {
                    name = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged("FullInfo");
                }
            }
        }
        string email;
        public string Email {
            get { return email; }
            set {
                if (email != value) {
                    email = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged("FullInfo");
                }
            }
        }
        public string FullInfo {
            get {
                return String.Format("{0} ({1})", this.Name, this.Email);
            }
        }
    }
}
