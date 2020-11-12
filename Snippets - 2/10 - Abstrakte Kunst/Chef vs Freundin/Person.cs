using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef_vs_Freundin {
    class Person : IEmployee, IFriend {
        public string Name { get; set; }
        void IEmployee.GetCalled() {
            Console.WriteLine("Ja Chef?");
        }
        void IFriend.GetCalled() {
            Console.WriteLine("Was gibt es mein Schatz?");
        }

        public void GetCalled() {
            Console.WriteLine("Wer schreit den jetzt?");
        }

        public void BeCool() {
        }

        public void GetFired() {
        }
    }
}
