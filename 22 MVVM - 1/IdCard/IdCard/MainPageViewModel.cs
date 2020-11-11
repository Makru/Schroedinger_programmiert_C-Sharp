using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdCard {
    public class MainPageViewModel : INotifyPropertyChanged {
        public MainPageViewModel() {
            this.Person = new Person();
            this.Person.Name = "Schrödinger";
            this.Person.Email = "schroedinger@galileo-computing.de";
        }
        public Person Person { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
