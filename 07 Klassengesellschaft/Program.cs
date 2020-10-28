using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Klassengesellschaft {
	class Program {
		static void Main(string[] args) {
			Person myPerson = new Person();
			myPerson.Lastname = "Schrödinger";
			myPerson.Size = 179;
			string name = myPerson.Lastname;

            Console.WriteLine(myPerson.Fullname6);
            Console.ReadKey();
		}
	}
}
