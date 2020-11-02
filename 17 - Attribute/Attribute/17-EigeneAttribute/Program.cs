using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _17_EigeneAttribute {
class Program {
		static void Main(string[] args) {
			//GetAuthorInfo(typeof(Person));
			GetAuthorInfo2(typeof(Person));
		}

		static void GetAuthorInfo(Type t) {
			AuthorAttribute attr = t.GetCustomAttribute<AuthorAttribute>();
			if (attr != null) {
				Console.WriteLine("Klassenautor: {0}; Version {1}", attr.Name, attr.Version);
			}

			Console.WriteLine("Methodenautoren");
			foreach (MethodInfo method in t.GetMethods()) {
				AuthorAttribute attribute = method.GetCustomAttribute<AuthorAttribute>();
				if (attribute != null)
					Console.WriteLine("Autor der Methode {0}: {1}; Version: {2}", method.Name, attribute.Name, attribute.Version);
			}
		}

		static void GetAuthorInfo2(Type t) {
			IEnumerable<AuthorAttribute> attr = t.GetCustomAttributes<AuthorAttribute>(true);
			if (attr != null && attr.Count() > 0) {
				Console.WriteLine("Klassenautoren");
				foreach (AuthorAttribute a in attr)
					Console.WriteLine("Klassenautor: {0}; Version {1}", a.Name, a.Version);
			}

			Console.WriteLine("Methodenautoren");
			foreach (MethodInfo method in t.GetMethods()) {
				IEnumerable<AuthorAttribute> attributes = method.GetCustomAttributes<AuthorAttribute>();
				if (attributes != null && attributes.Count() > 0) {
					Console.WriteLine("Autoren der Methode {0}:", method.Name);
					foreach (AuthorAttribute a in attributes) {
						Console.WriteLine("{0}: Version {1}", a.Name, a.Version);
					}
				}
			}
		}

	}
}
