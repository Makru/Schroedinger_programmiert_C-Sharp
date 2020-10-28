using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Anwendung {
	class Program {
		static void Main(string[] args) {
			// Wörterbuch mit Mitarbeiternummer und Name
			Dictionary<string, string> employees = new Dictionary<string, string>() {
				["MA-42"] = "Schrödinger",
				["MA-4711"] = "Max Müller",
				["MA-0815"] = "Florentina Müller",
				["MA-4093"] = "Hermine Mayer"
			};
			Console.WriteLine("Angestelltenverzeichnis:");
			Print(employees);
			Console.WriteLine("Ende");

			Dictionary<string, Dictionary<string, string>> employeesByLastname = new Dictionary<string, Dictionary<string, string>>(employees.Count);
			foreach (KeyValuePair<string, string> employee in employees) {
				string lastname = employee.Value;
				if (employee.Value.Contains(' '))
					lastname = employee.Value.Substring(employee.Value.IndexOf(' '));
				if (!employeesByLastname.ContainsKey(lastname))
					employeesByLastname.Add(lastname, new Dictionary<string, string>());
				employeesByLastname[lastname].Add(employee.Key, employee.Value);
			}
		}

		static void MainFunktioniert_NIcht(string[] args) {
			// Wörterbuch mit Mitarbeiternummer und Name
			Dictionary<string, string> employees = new Dictionary<string, string>() {
				["MA-42"] = "Schrödinger",
				["MA-4711"] = "Max Müller",
				["MA-0815"] = "Florentina Müller",
				["MA-4093"] = "Hermine Mayer"
			};
			Console.WriteLine("Angestelltenverzeichnis:");
			Print(employees);
			Console.WriteLine("Ende");

			Dictionary<string, string> employeesByLastname = new Dictionary<string, string>(employees.Count);
			foreach (KeyValuePair<string, string> employee in employees) {
				string lastname = employee.Value;
				if (employee.Value.Contains(' '))
					lastname = employee.Value.Substring(employee.Value.IndexOf(' '));
				employeesByLastname.Add(lastname, employee.Value);
			}

			Console.WriteLine("Angestelltenverzeichnis nach Nachname");
			Print(employeesByLastname);
			Console.WriteLine("Ende");
		}

		static void Print(Dictionary<string, string> dict) {
			foreach (var item in dict)
				Console.WriteLine($"{item.Key}\t{item.Value}");
		}
	}
}
