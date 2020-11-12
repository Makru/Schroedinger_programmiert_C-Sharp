using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef_vs_Freundin {
    class Program {
        static void Main(string[] args) {
            Person p = new Person();
            ((IFriend)p).GetCalled();
            ((IEmployee)p).GetCalled();
            p.GetCalled();

            IEmployee employee = new Person();
            employee.GetCalled();

            Person p2 = new Person();
            p2.GetCalled();
        }
    }
}
