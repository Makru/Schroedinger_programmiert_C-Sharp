using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Internet_Aufgabe {
	class Program {
		static void Main(string[] args) {
			Uri[] urls = new Uri[] {
				new Uri("http://www.galileocomputing.de/download/dateien/3018/galileocomputing_schroedinger_html5.pdf"),
				new Uri("http://www.galileocomputing.de/download/dateien/2734/galileocomputing_schroedinger_c_2B_2B.pdf"),
				new Uri("http://www.galileocomputing.de/download/dateien/2867/galileocomputing_programmieren_lernen_2..pdf"),
				new Uri("http://www.sap-press.de/download/dateien/2926/galileocomputing_schroedinger_abap.pdf")
			};
			foreach (Uri url in urls) {
				using (System.Net.WebClient client = new System.Net.WebClient()) {
					string filename = url.Segments[url.Segments.Length - 1];
					Console.WriteLine("Lade {0} herunter", filename);
					client.DownloadFile(url, @"C:\Schroedinger\" + filename);
				}
			}
			Console.WriteLine("Fertig");

		}
	}
}
