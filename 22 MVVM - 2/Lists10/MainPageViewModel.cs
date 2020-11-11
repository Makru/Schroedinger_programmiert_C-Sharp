using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists {
    public class MainPageViewModel : ModelBase {
        public ObservableCollection<Person> Persons { get; set; }

        public MainPageViewModel() {
            this.Persons = new ObservableCollection<Person>();
            this.Persons.Add(new Person() { Firstname = "Joan", Lastname = "Smalls" });
            this.Persons.Add(new Person() { Firstname = "Saskia", Lastname = "de Brauw" });
            this.Persons.Add(new Person() { Firstname = "Liu", Lastname = "Wen" });
            this.Persons.Add(new Person() { Firstname = "Claudia", Lastname = "Schiffer" });
            this.Persons.Add(new Person() { Lastname = "Schrödinger" });
        }

        bool isBig;
        public bool IsBig {
            get { return isBig; }
            set {
                if (isBig != value) {
                    isBig = value;
                    this.OnPropertyChanged();
                }
            }
        }

        Person selected = null;
        public Person SelectedPerson {
            get {
                return selected;
            }
            set {
                if (selected != value) {
                    selected = value;
                    this.OnPropertyChanged();
                }
            }
        }
    }
}
