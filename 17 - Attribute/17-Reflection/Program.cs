using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _17_Reflection {
	class Program {
		static void Main(string[] args) {
			Person p = new Person() {
				Firstname = "Meister",
				Lastname = "Schrödinger",
				Email = "Schroedinger@galileo-press.de"
			};

			Type personType = p.GetType();
			Type personType1 = typeof(Person);
			Console.WriteLine("Typ: " + personType.Name);
			Console.WriteLine("Typ mit Namespace: " + personType.FullName);
			Console.WriteLine(personType == personType1);
			PropertyInfo[] properties = personType.GetProperties();
			foreach (PropertyInfo prop in properties) {
				Console.WriteLine("Eigenschaft: {0} - Wert: {1}", prop.Name, prop.GetValue(p));
			}
			MethodInfo fullNameMethod = personType.GetMethod("GetFullName");
			Console.WriteLine("Methode {0} aufgerufen ergibt: {1}",
				fullNameMethod.Name,
				fullNameMethod.Invoke(p, null)
			);

			ObsoleteAttribute attr = (ObsoleteAttribute)personType.GetCustomAttribute(typeof(ObsoleteAttribute));
			if (attr != null) {
				Console.WriteLine("Oje, das Objekt ist dem Untegang geweiht! {0}", attr.Message);
			}
		}
	}
}
