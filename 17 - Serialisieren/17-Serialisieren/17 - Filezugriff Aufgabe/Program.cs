using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Filezugriff_Aufgabe {
	class Program {
		// V2
		static void Main(string[] args) {
			string directory = @"c:\users\bernhard\desktop";
			DirectoryInfo dir = new DirectoryInfo(directory);
			HashSet<string> extensions = new HashSet<string>();

			foreach (FileInfo file in dir.GetFiles())
				if (extensions.Add(file.Extension.ToLower()))
					Console.WriteLine("Gefundene Dateiendung: {0}", file.Extension);
		}
		// V1
		//static void Main(string[] args) {
		//	string directory = @"c:\users\bernhard\desktop";
		//	DirectoryInfo dir = new DirectoryInfo(directory);
		//	HashSet<string> extensions = new HashSet<string>();

		//	foreach (FileInfo file in dir.GetFiles())
		//		extensions.Add(file.Extension);

		//	foreach (string extension in extensions)
		//		Console.WriteLine("Gefundene Dateiendung: {0}", extension);

		//}

	}
}
